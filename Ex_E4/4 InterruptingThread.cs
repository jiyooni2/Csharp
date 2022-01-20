using System;
using System.Security.Permissions;
using System.Threading;

namespace InterruptingThread
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
            //param 이 co 라면
            //count=co; 해도 됨, 이름이 같아서 this keyword use
        }

        public void KeepAlive()
        {
            try
            {
                Console.WriteLine("Running thread isn't gonna be interrupted");
                Thread.SpinWait(1000000000);
                //running 상태 유지하면서, loop돌면서 시간 보냄
                //이거돌릴 때는 interrupt 발생 안됨
                while (count > 0)
                {
                    Console.WriteLine("{0} left", count--);

                    Console.WriteLine("Entering into WaitJoinSleep State...");
                    Thread.Sleep(10);
                    //이순간에 interrupt,
                    //catch로 흐름제어 넘어감
                }
                Console.WriteLine("Count : 0");
            }
            //catch 없으면 그냥 끝냄
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting thread...");
            t1.Start();

            Thread.Sleep(100);

            Console.WriteLine("Interrupting thread...");
            t1.Interrupt();

            Console.WriteLine("Wating until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}

using System;
using System.Threading;

namespace AbortingThread
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                while (count > 0)
                {
                    Console.WriteLine("{0} left", count--);
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count : 0");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e);
                //error msg 출력
                //Abort reset
                Thread.ResetAbort();
            }//Abort발생시 여기로 넘어감
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
            //main thread는 sleep
            //깨어난 뒤 출력하고 t1.Abort()
            Console.WriteLine("Aborting thread...");
            t1.Abort();
            //t1에 throw ThreadAbortException

            Console.WriteLine("Wating until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");
        }
    }
}

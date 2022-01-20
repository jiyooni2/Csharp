using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SchedulerApp
{
    class Program
    {
        static int interval;//class소속 이미 존재
        static void ThreadBody()
        {
            Thread myself = Thread.CurrentThread;
            //myself > worker thread
            Console.WriteLine("Starting Thread : " + myself.Name);
            for (int i = 1; i <= 10 * interval; i++)
            {
                if (i % interval == 0)
                    Console.WriteLine(myself.Name + " : " + i);
            }
            Console.WriteLine("Ending Thread : " + myself.Name);
        }
        public static void Main()
        {
            Console.Write("Interval value : ");
            interval = int.Parse(Console.ReadLine());
            //class안에있으니까 static 쓸 필요 없음
            Thread.CurrentThread.Name = "Main Thread";
            //CurrentThread : 현재 실행중인 thread
            // Thread.CurrentThread.Priority=ThreadPriority.Highest;
            Thread worker = new Thread(new ThreadStart(ThreadBody));
            worker.Name = "Worker Thread";
            worker.Start();
            ThreadBody();//main도 ThreadBody 실행
            //worker, main 번갈아가면서 실행
        }
    }
}

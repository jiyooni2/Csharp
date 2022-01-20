using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPriorityApp
{
    class Program
    {
        static void ThreadBody()
        {
            Thread.Sleep(1000);
        }
        public static void Main()
        {
            Thread t = new Thread(new ThreadStart(ThreadBody));
            t.Start();
            Console.WriteLine("Current Priority : " + t.Priority);
            ++t.Priority;
            Console.WriteLine("Higher Priority : " + t.Priority);

            //어떤순서로 스케쥴될지모름
            //main 과 t중 누가먼저 실행될지도 모름
            //우리가 알 수 있는건 아주 높은 확률로 우선순위가 높은
            //스레드가 실행된다
        }
    }
}

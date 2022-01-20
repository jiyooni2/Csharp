using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SimpleThreadApp
{
    class Program
    {
        static void ThreadBody()                            // --- 1
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(DateTime.Now.Second + " : " + i);
                Thread.Sleep(1000);
            }
        }
        public static void Main()
        {
            ThreadStart ts = new ThreadStart(ThreadBody);   // --- 2
            //ts는 ThreadStart delegate
            //delagate에 ThreadBody method 연결
            Thread t = new Thread(ts);                      // --- 3
            Console.WriteLine("*** Start of Main");
            t.Start();                                      // --- 4
            Console.WriteLine("*** End of Main");
            //main도 하나의 thread이므로, End가 당연히 먼저 될 수 있겠지
            //main을 포함한 모든 thread가 끝나야 프로세스 종료
        }
    }
}

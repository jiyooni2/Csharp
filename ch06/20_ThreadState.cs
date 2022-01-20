using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStateApp
{
    class ThreadState
    {
        public void ThreadBody()
        {
            while (true)
            {
                // ... infinite loop ...
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            ThreadState obj = new ThreadState();
            ThreadStart ts = new ThreadStart(obj.ThreadBody);
            Thread t = new Thread(ts);
            Console.WriteLine("Step 1: " + t.ThreadState);
            //unstarted

            t.Start();//t가 start함을 보증하긴 힘듬
            //t아직 시작안하고 console.WriteLine실행할 수 있음
            Thread.Sleep(100);//main method가 sleep

            Console.WriteLine("Step 2: " + t.ThreadState);
            //이게 나중에 실행되어야 Running이뜨는것

            t.Suspend();
            Thread.Sleep(100);
            Console.WriteLine("Step 3: " + t.ThreadState);
            //t가 suspend하기 전에, 실행될수도 있으니까 sleep


            t.Resume();
            //서로의 스레드는 서로를 제어 가능
            //서로 믿는 프로그램이므로
            //Runnable에서 스케쥴이 되야 running
            //Runnable일지 running일지 모름

            Thread.Sleep(100);
            Console.WriteLine("Step 4: " + t.ThreadState);
            t.Abort();
            Thread.Sleep(100);
            Console.WriteLine("Step 5: " + t.ThreadState);
        }
    }
}

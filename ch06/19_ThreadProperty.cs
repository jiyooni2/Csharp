using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadPropertyApp
{
    class ThreadProperty
    {
        public void ThreadBody()
        {
            Thread myself = Thread.CurrentThread;
            //Thread.CurrentThread는 class소속이고 1개만 있는 것, 객체마다 따로 잇는것이 아님
            //현재 실행중인 thread 가르킴
            //가져가면 이 코드 실행하니까, myself='나'가 됨
            //t1과 t2의 myself는 다름
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0} is activated => {1}",
                    myself.Name, i);
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            ThreadProperty obj = new ThreadProperty();
            //static이 아니니까 obj 생성해야지만 code가 존재하니까 객체 생성한 것
            ThreadStart ts = new ThreadStart(obj.ThreadBody);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Name = "Apple"; t2.Name = "Orange";
            t1.Start(); t2.Start();//main t1 t2 3개의 스레드 병행 실행
            //core가 1개면 3개의 스레드 번갈아가면서 실행
            //multi core면 core마다 1개의 스레드 실행
        }
    }
}

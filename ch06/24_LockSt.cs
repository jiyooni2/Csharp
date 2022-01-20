using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LockStApp
{
    class ThreadProperty
    {
        public void ThreadBody()
        {
            Thread myself = Thread.CurrentThread;
            lock (this)//자기자신객체
            {
                //여기서도 lock에 전달된 변수가 block 선점 가능
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("{0} is activated => {1}", myself.Name, i);
                    Thread.Sleep(1000);
                    //이렇게 오래 쉬어도 그 어떤 thread도 중간에 못 끼어들음
                }
                //이 block은 순차적으로 한번 씩 실행
                //어떤 스레드가 진입하면 다른 스레드는 진입 불가
                //lock문장은 block단위 lock
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            ThreadProperty obj = new ThreadProperty();
            ThreadStart ts = new ThreadStart(obj.ThreadBody);
            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);
            t1.Name = "Apple"; t2.Name = "Orange";
            t1.Start(); t2.Start();
            //총 3개 thread
            //main이 먼저 끝날수도 있음
            //t1, t2까지 다 끝나면 프로그램 종료
        }
    }
}

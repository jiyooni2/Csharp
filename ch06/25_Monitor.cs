using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MonitorApp
{
    class ThreadProperty
    {
        public void ThreadBody()
        {
            Thread myself = Thread.CurrentThread;
            Monitor.Enter(this);
            //매개변수로 전달된 thread가
            //특정 문장을 선점할 수 있도록 한다!
            //this를 써야하는 이유

            //다른 thread 진입 불가
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("{0} is activated => {1}",
                    myself.Name, i);
                Thread.Sleep(1000);
            }
            Monitor.Exit(this);
            //다른 thread 진입
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
        }
    }
}

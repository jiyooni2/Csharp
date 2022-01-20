using System;
using System.Threading;

namespace WaitPulse
{
    class Counter
    {
        const int LOOP_COUNT = 1000;

        readonly object thisLock;
        bool lockedCount = false;

        private int count;
        public int Count
        {
            get { return count; }
        }

        public Counter()
        {
            thisLock = new object();
            count = 0;
        }//Property

        public void Increase()
        {
            int loopCount = LOOP_COUNT;

            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count > 10)
                        Monitor.Wait(thisLock);
                    //lock반납
                    count++;
                    //producer

                    Monitor.Pulse(thisLock);
                    //깨워준후에 둘중 하나
                    //1.count계속 증가해서 11이 되어서, 소비지가 실행 
                    //2.일단빠져나가는 방법(Hoare)
                    //OS
                }
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNT;

            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    //wait해서 lock을 풀어줘야 들어옴
                    while (count <= 0)
                        Monitor.Wait(thisLock);
                    count--;
                    //consumer
                    Monitor.Pulse(thisLock);
                }
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread incThread = new Thread(
                new ThreadStart(counter.Increase));
            Thread decThread = new Thread(
                new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}
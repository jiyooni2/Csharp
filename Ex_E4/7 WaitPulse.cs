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
                    while (count > 0 || lockedCount == true)
                        Monitor.Wait(thisLock);
                    //조건이 안맞으면 wait
                    //서로가 서로를 깨워줄책임이 있음(동기화)
                    //멈추고 기다리려면, lock을 해제하고 기다림

                    lockedCount = true;
                    //한번에 하나씩만 들어와서 의미 없음
                    count++;
                    //producer
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
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
                    while (count < 0 || lockedCount == true)
                        Monitor.Wait(thisLock);

                    lockedCount = true;
                    count--;
                    //consumer
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                    //wait하던 애가 깨어남
                    //동시에 둘다는 못함
                    //pulse끝나고 빠져나가야지 wait실행 가능
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
using System;
using System.Threading;

namespace Synchronize
{
    class Counter
    {
        const int LOOP_COUNT = 1000;

        readonly object thisLock;

        private int count;
        public int Count
        {
            get { return count; }
        }//Count property

        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increment()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    count++;
                }
                Thread.Sleep(1);
            }
        }
        //increment, decrement method둘다, thislock obj를 표지판으로 한번에 하나씩 사용 가능
        //block 단위
        public void Decrement()
        {
            int loopCount = LOOP_COUNT;
            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    count--;
                }
                Thread.Sleep(1);
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread incThread = new Thread(
                new ThreadStart(counter.Increment));
            Thread decThread = new Thread(
                new ThreadStart(counter.Decrement));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}

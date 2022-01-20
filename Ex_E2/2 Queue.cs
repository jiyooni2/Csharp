using System;
using System.Collections;

namespace UsingQueue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());
            //12345 나옴
            //FIFO
            //먼저넣은 것 먼저나옴 
        }
    }
}

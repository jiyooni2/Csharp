using System;
using System.Collections.Generic;

namespace UsingGenericQueue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            //여러가지 데이터 섞어쓰진 못하지만
            //성능면에서 이점 O

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());
        }
    }
}

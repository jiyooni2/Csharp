using System;
using System.Collections.Generic;

namespace UsingGenericList
{
    class MainApp
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);
            //int만 넣어줘야 함!
            //선언만 다르고 다 똑같음


            foreach (int element in list)
                Console.Write("{0} ", element);
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (int element in list)
                Console.Write("{0} ", element);
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (int element in list)
                Console.Write("{0} ", element);
            Console.WriteLine();
        }
    }
}

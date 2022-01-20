using System;
using System.Collections;

namespace UsingList
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (object obj in list)
                //array와 거의 비슷하게 취급함
                //value type을 넣어도 object로 받음
                //boxing
                Console.Write("{0} ", obj);
            Console.WriteLine();

            list.RemoveAt(2);
            //0 start, 01234

            foreach (object obj in list)
                Console.Write("{0} ", obj);
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (object obj in list)
                Console.Write("{0} ", obj);
            Console.WriteLine();

            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
                //list.Count = Array.Length
                Console.Write("{0} ", list[i]);
            Console.WriteLine();
        }
    }
}



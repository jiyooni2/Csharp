using System;
using System.Collections;

namespace Enumerable
{
    class MyList : IEnumerable, IEnumerator
    //이 두가지 인터페이스 상속해야함
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {//인덱서
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    //index+1로 size증가
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }

                array[index] = value;
            }
        }

        // IEnumerator 멤버(상속)
        public object Current
        {
            get
            {
                return array[position];
            }
        }

        // IEnumerator 멤버
        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        // IEnumerator 멤버
        public void Reset()
        {
            position = -1;
        }
        //사실 여기서는 Current, MoveNext, Reset안썻음

        // IEnumerable 멤버
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return (array[i]);
            }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;
            //인덱서 사용

            foreach (int e in list)
                Console.WriteLine(e);
        }
    }
}

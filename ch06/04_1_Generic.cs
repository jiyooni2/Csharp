using System;

namespace Generic
{
    class MyList<T>
    {
        private T[] array;//array객체 포인터 생성

        public MyList()
        {
            //Constructor , <T>필요 없음
            array = new T[3];//array에 pointer 연결
        }

        public T this[int index]//객체이름[index]
        {//indexer 사용
            get
            {
                return array[index];
            }

            set
            {
                if (index >= array.Length)
                {//array크기 3인데 index 5를 줄 경우
                    Array.Resize<T>(ref array, index + 1);
                    //Array의 크기를 조절 index+1 : 원하는 크기
                    //index가 5가오면, array[5] > 6개를 만들어야 되니까
                    Console.WriteLine("Array Resized : {0}", array.Length);
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
        //그냥 array.Length써도 되는데, private이므로 접근 못하니까 property만들어서 접근
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";//Indexer
            //str_list 안의 array 변수를 property느낌으로다가 쉽게 접근
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";//Length를 4로 변경하고 3 index에 삽임
            str_list[4] = "mno";//Length를 5로 변경하고 4 index에 삽입

            for (int i = 0; i < str_list.Length; i++)
                Console.WriteLine(str_list[i]);

            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;//resize
            int_list[4] = 4;


            //int_list.Length property사용해서
            //get Length field
            for (int i = 0; i < int_list.Length; i++)
                Console.WriteLine(int_list[i]);
            //인덱서 사용했으니까 그냥 int_list[i]
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassApp
{
    class SimpleGeneric<T>
    //이렇게 정의한 순간부터 생성자는 T
    //T1,T2이면 <T1,T2>
    //왜냐면 클래스 내부에서 T1,T2를 많이 생성했기 때문
    {
        private T[] values;//T를 integer라고 생각해보기
        //array객체를 가르키는 values pointer
        private int index;

        public SimpleGeneric(int len)
        { // Constructor
          //Constructor에 <T>안붙이고 T 사용 가능
          //실제로 호출할때는 붙임
            values = new T[len];//len길이의 array 객체 만들어서 포인터 연결
            index = 0;
        }

        public void add(params T[] args)
        {//params : 가변 매개변수
            //데이터 여러개 들어오면 그걸 T형 array로 만들어서 넘겨줌
            //만약 params를 빼고, 뒤 코드가 실행되려면
            //실제로 array를 넘겨주어야 한다
            //이 array의 길이는 중요하지 않음
            foreach (T e in args)
                values[index++] = e;
        }

        public void print()
        {
            foreach (T e in values)
                Console.Write(e + " ");
            //만약에 T가 class라면, T의 ToString method가 호출되겠지
            Console.WriteLine();
        }
    }

    public class Program
    {
        public static void Main()
        {
            SimpleGeneric<Int32> gInteger = new SimpleGeneric<Int32>(10);
            SimpleGeneric<Double> gDouble = new SimpleGeneric<Double>(10);

            gInteger.add(1, 2);
            gInteger.add(1, 2, 3, 4, 5, 6, 7);
            gInteger.add(0);
            gInteger.print();

            gDouble.add(10.0, 20.0, 30.0);
            gDouble.print();
        }
    }
}
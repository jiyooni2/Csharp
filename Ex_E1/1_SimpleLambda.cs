using System;

namespace SimpleLambda
{
    class MainApp
    {
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            Calculate calc = (a, b) => a + b;
            //익명 메소드 정의하고 calc가 그것을 가르킴            

            //람다식에 의해서, method가 정의된다.
            //그 익명 method를 calc가 가르킨다.

            Console.WriteLine("{0} + {1} : {2}", 3, 4, calc(3, 4));
        }
    }
}

using System;

namespace FuncTest
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 10;
            //param : void, ret : int

            //generic으로 param의 type 넘겨준다!!
            Console.WriteLine("func1() : {0}", func1());

            Func<int, int> func2 = (x) => x * 2;
            //param : int, ret : int
            Console.WriteLine("func2(4) : {0}", func2(4));

            Func<double, double, double> func3 =
                (x, y) => x / y;
            //param : double, double
            //ret : double

            Console.WriteLine("func3(22/7) : {0}", func3(22, 7));
        }
    }
}

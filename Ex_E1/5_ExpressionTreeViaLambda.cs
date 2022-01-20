using System;
using System.Linq.Expressions;

namespace ExpressionTreeViaLambda
{
    class MainApp
    {

        static void Main(string[] args)
        {
            //type parameter로 Func 가르킴
            //Expression Tree에 Func를 주면 알아서 식트리가 만들어짐
            Expression<Func<int, int, int>> expression =
                (a, b) => 1 * 2 + (a - b);


            Func<int, int, int> func = expression.Compile();
            //expression을 compile 해서, func delegate가 그걸 가르키게함

            // x = 7, y = 8
            Console.WriteLine("1*2+({0}-{1}) = {2}", 7, 8, func(7, 8));
        }
    }
}

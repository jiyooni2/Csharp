using System;
using System.Linq;

namespace From
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers
                             //numbers에서 객체(n)를 꺼냄
                             //element 하나하나를 n이라 칭함(foreach)
                         where n % 2 == 0
                         orderby n
                         select n;
            //select문에 의해서 List Collection이 만들어짐
            //이 데이터들만 골라와서 그걸 가져와서 result가 가르키게 함
            //result는 foreach가능
            //object이면 var n 해야겠지
            foreach (int n in result)
                Console.WriteLine("짝수 : {0}", n);
        }
    }
}

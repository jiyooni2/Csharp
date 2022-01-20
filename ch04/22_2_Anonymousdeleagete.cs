using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateOperationApp
{
    class Program
    {
        public delegate int Calculate(int a, int b);
        public int calc(int a, int b)
        {
            return a + b;
        }//인스턴스 method
        //program class 선언해야 사용가능

        public static void Main()
        {
            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(calc(3, 4));
            //여기서 쓰인 calc는 delegate
        }
    }
}

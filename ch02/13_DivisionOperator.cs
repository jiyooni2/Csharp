using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionOperatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; double x;
            i = 1 / 2;//i=0
            x = 1 / 2;//x=0, 0.0으로 묵시적 형변환
            Console.Write("i = " + i);
            Console.WriteLine(", x = " + x);
            i = (int)(1 / 2.0);
            x = 1 / 2.0;//묵시적 형변환, double로 들어감
            Console.Write("i = " + i);
            Console.WriteLine(", x = " + x);
        }
    }
}

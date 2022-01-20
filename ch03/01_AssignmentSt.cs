using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingmentStApp
{
    class Program
    {
        static void Main(string[] args)
        {
            short s; int i;
            float f; double d;
            s = 526;
            d = f = i = s;
            //short에서 int로 묵시적 형변환
            //int에서 float로 묵시적 형변환
            //float에서 double로 묵시적 형변환
            //묵시적 형변환이 되므로 값은 그대로
            Console.WriteLine("s = " + s + " i = " + i);
            Console.WriteLine("f = " + f + " d = " + d);
        }
    }
}

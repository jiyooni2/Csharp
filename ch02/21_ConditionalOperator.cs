using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int m;
            Console.Write("Enter three numbers : ");
            a = Console.Read() - '0';
            b = Console.Read() - '0';
            c = Console.Read() - '0';
            //unicode 값으로 return 되는데,
            //1~0, a~z 문자 순서대로 있으니까
            //unicode의 차이가, 값의 차이다.
            //int - unicode : 형변환 발생
            //Console.Read는 int return
            m = (a > b) ? a : b;
            m = (m > c) ? m : c;
            Console.WriteLine("The largest number = " + m);
        }
    }
}

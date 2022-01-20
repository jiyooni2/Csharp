using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakStApp
{
    class Program
    {   // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
        static void Main(string[] args)
        {
            int n, i;
            double h = 0.0;
            Console.Write("Enter a number = ");
            n = Console.Read() - '0';
            i = 1;
            while (true)
            {
                h = h + 1 / (double)i;
                if (++i > n) break;
                //이 if문 안이 실행되든 말든
                //조건식 검사는 이루어지므로 i 증가
            }
            Console.WriteLine(" n = " + n + ", h = " + h);
            Console.WriteLine(n + " " + h);
            //이러면 모두 string형태로 바뀜
            //더해지지 않고 출력

        }
    }
}

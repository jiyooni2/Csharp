using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContinueStApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, s, i;
            Console.Write("Enter a number = ");
            for (; ; )
            {
                n = Console.Read() - '0';
                //내가 입력한 line을 어디 buffer에 두고
                //계속 한글자씩 읽는 개념
                if (n == 0) break;
                else if (n < 0) continue;
                //-5를 넣어도 안돌아가는 이유는
                //-한 char를 읽어가서 그러니까 0미만이아니라 어떤 특정값을 넣어야 돌아감
                for (s = 0, i = 1; i <= n; ++i)
                    s += i;
                Console.WriteLine("n = " + n + ", sum = " + s);
            }
            Console.WriteLine("End of Main");
        }
    }
}

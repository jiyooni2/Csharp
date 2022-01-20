using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompoundStApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter one digit = ");
            n = Console.Read() - '0';
            //입력된 문자의 유니코드 값에서 0의 유니코드 값을 뺌
            //묵시적 형 변환이 되더라도 값은 그대로니까
            //unicode - unicode(0) = 숫자값이나옴
            if (n < 0)
                Console.WriteLine("Negative number !");
            else
            {
                Console.WriteLine(n + " squared is " + (n * n));
                Console.WriteLine(n + " cubed is " + (n * n * n));
            }
        }
    }
}

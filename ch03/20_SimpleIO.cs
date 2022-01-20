using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIOApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i; char c;
            Console.Write("Enter a digit and a character = ");
            i = Console.Read() - 48;//48='0'의 unicode값

            c = (char)Console.Read();
            //char로 casting
            //char : unicode
            //unicode를 int로 return 한 것을, char로 casting하니까
            //unicode에 해당하는 문자 return
            Console.Write("i = " + i);
            Console.WriteLine(", c = " + c);
        }
    }
}

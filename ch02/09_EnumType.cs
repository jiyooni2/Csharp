using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumTypeApp
{
    enum Color { Red, Green, Blue };
    //enum은 메인 보다는 밖에 위치해야한다
    class Program
    {
        static void Main(string[] args)
        {
            Color c = Color.Red;
            c++;
            int i = (int)c;
            Console.WriteLine("Cardinality of " + c + " = " + i);
        }
    }
}
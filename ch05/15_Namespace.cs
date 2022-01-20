using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shape;
//같은데에다 넣고 사용하면 using으로 library처럼 import가능

namespace NamespaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.width = 10;
            rect.height = 20;
            Console.WriteLine("rect : " + rect);
        }
    }
}

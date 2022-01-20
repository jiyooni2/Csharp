using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalVariableApp
{
    class LocalVariable
    {
        public static int x;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = (LocalVariable.x = 2) * 2;
            Console.WriteLine("static x = " + LocalVariable.x);
            //여기서는 x랑 LocalVarible.x기 때문에 구분가능
            Console.WriteLine("local  x = " + x);
        }
    }
}

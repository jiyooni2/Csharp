using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverflowApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, max = int.MaxValue;
            i = max;
            try
            {

                Console.WriteLine("Start of try statement");
                Console.WriteLine("before : " + i);
                i = max + 1;     // default: don't check Overflow.
                Console.WriteLine("After : " + i);
                Console.WriteLine("After default overflow");
                unchecked
                {
                    i = max + 1; // don't check Overflow intensionally.
                }
                Console.WriteLine("After unchecked statement");
                checked
                {
                    i = max + 1; // check Overflow
                }//overflow catch, catch 문장 execute
                Console.WriteLine("After checked statement");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("caught an OverflowException");
            }
        }
    }
}

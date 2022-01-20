using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyClauseApp
{
    class Program
    {
        static int count = 0;
        public static void Main()
        {
            while (true)
            {
                try
                {
                    ++count;
                    if (count == 1) throw new Exception();
                    if (count == 3) break;
                    //3에서 break가 되어도 try 먼저 빠져나옴
                    //try 빠져나가면서 finally 실행
                    //finally는 try안으로 들어갔으면 break가 걸려도
                    //finally실행 후 break
                    Console.WriteLine(count + ") No exception");
                }
                catch (Exception)
                {
                    Console.WriteLine(count + ") Exception thrown");
                }
                finally
                {
                    Console.WriteLine(count + ") in finally clause");
                }
            } // end while
            Console.WriteLine("Main program ends");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropagateApp
{
    class Propagate
    {
        public void Orange()
        {
            int i = 25, j = 0;
            i = i / j;
            //Exception발생, 일단 여기에서 catch 있는지 check
            //없으면 불렀던 곳으로
            Console.WriteLine("End of Orange method");
        }
        public void Apple()
        {
            try
            {
                Orange();
                //Orange에서 throw ArithmeticException
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Exception");
                throw e;//exception처리 후 한번 더 예외 throw
                //다시 위로 올라가서 error 처리하라는 의미(propagate)
            }
            Console.WriteLine("End of Apple method");
        }
    }
    class Program
    {
        public static void Main()
        {
            Propagate p = new Propagate();
            try
            {
                p.Apple();
                //Apple에서 throw Exception
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("ArithmeticException is processed");

            }
            Console.WriteLine("End of Main");
        }
    }
}

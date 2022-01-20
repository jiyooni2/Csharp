using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattedOutputApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1) {0,-5},{1,5},{2,5}", 1.2, 1.2, 123.45);//argument 0,1,2
            //0번째 argument, 1번째 argument, 2번째 argument -5,5,5 폭 value
            Console.WriteLine("1) ", 1.2, 1.2, 123.45);
            double d = Math.PI;
            Console.WriteLine("2) {0}", d);
            Console.WriteLine("3) {0:C}", d);
            Console.WriteLine("4) {0:E}", d);
            Console.WriteLine("5) {0:F}", d);
            Console.WriteLine("6) {0:G}", d);
            Console.WriteLine("7) {0:P}", d);
            Console.WriteLine("8) {0:R}", d);
            Console.WriteLine("9) {0:X}", 255);
        }
    }
}

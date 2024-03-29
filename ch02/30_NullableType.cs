﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypeApp
{
    class Program
    {
        public static void Main()
        {
            double? num1 = null;
            double? num2 = 10.0;

            //Console.WriteLine(num1);
            //null이니까 print하면 공백나옴
            //Console.WriteLine(num2);
            //둘다 됨

            if (num1.HasValue)
                Console.WriteLine("num1 = " + num1.Value);
            else
                Console.WriteLine("num1 does not have value.");
            if (num2.HasValue)
                Console.WriteLine("num2 = " + num2.Value);
            else
                Console.WriteLine("num2 does not have value.");
        }
    }
}
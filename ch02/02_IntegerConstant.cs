﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerConstanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 255, h = 0Xff;
            long l = 0XffL;
            Console.WriteLine("i = {0}, h = {1}", i, h);
            if (h == l) Console.WriteLine("Yes");
            //같은지 여부는 값에 따라
            else Console.WriteLine("No");
        }
    }
}

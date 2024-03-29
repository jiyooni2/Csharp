﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallByValueApp
{
    class Program
    {
        static void Swap(int x, int y)
        {//그냥 void Swap하면, Main함수에서 사용 불가
            int temp;
            temp = x; x = y; y = temp;
            Console.WriteLine("  Swap: x = {0}, y = {1}", x, y);
        }
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            Console.WriteLine("Before: x = {0}, y = {1}", x, y);
            Swap(x, y);
            Console.WriteLine(" After: x = {0}, y = {1}", x, y);
        }
    }
}
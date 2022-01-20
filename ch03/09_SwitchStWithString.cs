using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStWithString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the weekday (Sunday-Saturday) : ");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Sunday": goto case "Monday";
                case "Monday": goto case "Tuesday";
                case "Tuesday": Console.WriteLine(3); break;
                case "Wednesday": Console.WriteLine(4); break;
                case "Thursday": Console.WriteLine(5); break;
                case "Friday": Console.WriteLine(6); break;
                case "Saturday": Console.WriteLine(7); break;
                default: Console.WriteLine("Illegal day"); break;
            }
        }
    }
}
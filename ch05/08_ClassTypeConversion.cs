using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeConversionApp
{
    class CLanguage
    {
        public bool Equal(object obj)//object type이면, 어떤 object든 가능
        {
            if (obj is CLanguage) return true;
            else return false;
        }
    }
    class CSharp : CLanguage
    {
        new public bool Equal(object obj)//Hiding
        {
            return (obj is CSharp) ? true : false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CLanguage c = new CLanguage();
            CSharp cs = new CSharp();

            if (c.Equal(cs)) Console.WriteLine("casting up is valid.");
            //obj가 c인지 return
            //obj는 cs타입, cs가 c가 될 수 있으므로
            //return true

            else Console.WriteLine("casting up is not valid.");
            if (cs.Equal(c)) Console.WriteLine("casting down is valid.");
            else Console.WriteLine("casting down is not valid.");
        }
    }
}

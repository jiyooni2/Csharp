using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Fraction
    {
        //private int numerator;
        //private int denominator;

        public int Numerator { get; set; }
        //자동구현 private field 알아서 하나 만들어줌
        //이름은 알아서 정하고 뭐로 만드는지는 나도 모름
        //access할 수 있는 방법이 없음, property로만 접근 가능
        public int Denominator { get; set; }

        override public string ToString()
        {
            return (Numerator + "/" + Denominator);
        }
    }
    class Program
    {
        public static void Main()
        {
            Fraction f = new Fraction(); int i;
            f.Numerator = 1;   // invoke set-accessor in Numerator
            i = f.Numerator + 1; // invoke get-accessor in Numerator
            f.Denominator = i; // invoke set-accessor in Denominator
            Console.WriteLine(f.ToString());
        }
    }
}

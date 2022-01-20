using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedConstructorApp
{
    class Fraction
    {
        int numerator;                        // 분자 필드
        int denominator;                      // 분모 필드

        public Fraction()
        {                   // 디폴트 생성자 안만들어도 있음
            numerator = 0;
            denominator = 1;
        }
        public Fraction(int n)
        {              // 생성자
            numerator = n;
            denominator = 1;
        }
        public Fraction(int n, int d)
        {      // 생성자
            numerator = n;
            denominator = d;
        }//생성자 overloading 3개
        override public String ToString()
        {
            return (numerator + "/" + denominator);
            //return String, numerator,denominaotr string type으로 바꿔줌
        }//원래 모든 클래스마다 상속받아서 ToString있음
        //console.writeline할 때 tostring해서 호출해주는것
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(), f2 = new Fraction(2),
            f3 = new Fraction(1, 2);
            Console.WriteLine("f1 = {0}, f2 = {1}, f3 = {2}",
                f1, f2, f3);
            //Console.WriteLine에 객체를 주면 Tostring을 불러서
            //string으로 바꿔서 return값을 넘겨줌
            //f1에 ToString method 불리면서 들어감
            //return된 string이 {0},{1},{2}에 들어감
        }
    }
}
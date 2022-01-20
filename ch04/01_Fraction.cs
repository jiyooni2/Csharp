using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionApp
{
    //프로그램은 namespace부터 시작
    //여러개의 class포함할 수 있으며 이 중 한개의 class는 main func있어야 함
    //여러개의 namespace를 가질 수 있음
    //다른 namespace를 쓰려면
    //namespace.class.field/method 해야함
    
    class Fraction
    {
        int numerator;                              // 분자 필드
        int denominator;                            // 분모 필드
        public Fraction(int num, int denom) {       // 생성자
            numerator = num;
            denominator = denom;
        }
        public void PrintFraction() {               // 출력 메소드
            Console.WriteLine(numerator + "/" + denominator);
        }

        override public String ToString()//String이나 string이나 차이 X
            //String은 좀 더 class개념 강한느낌
            //string은 좀 더 object개념 강한느낌
        {
            return (numerator + "/" + denominator);
        }
    }
    class Program {
        static void Main(string[] args) 
        //static으로 정의해서, class정의한 순간부터 이코드 시작하고 main start
        {
            Fraction f = new Fraction(1, 2);
            //heap에 obj만들고 obj pointer인 f가 가르킴
            f.PrintFraction();
        }
    }
}

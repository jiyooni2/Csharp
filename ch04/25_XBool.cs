using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBoolApp
{
    class XBool
    {
        public bool b;
        // XBool 형을 bool 형으로 명시적으로 변환하는 연산자 중복
        public static explicit operator bool(XBool x)
        {//명시적 형 변환 operator bool
            Console.WriteLine("In the explicit operator bool ...");
            return x.b;
        }//존재하는 data type만 가능함, return type도 bool 이어야함
        //double, int 다 class니까, 다른 객체로의 형변환도 가능하겠지

        // XBool 형에 대한 true 연산자의 중복
        public static bool operator true(XBool x)
        {
            Console.WriteLine("In the operator true ...");
            return x.b ? true : false;
            //b가 true면 true return
        }
        // XBool  형에 대한 false 연산자의 중복
        public static bool operator false(XBool x)
        {
            Console.WriteLine("In the operator false ...");
            return x.b ? false : true;
            //b가 true면 false return
        }
    }
    class Program
    {
        public static void Main()
        {
            XBool xb = new XBool();
            xb.b = false;
            if (xb)                      // invoke operator true
                //bool(xb)하면, explicit 변환 연산 나옴
                //C#에서는 condition에 어떤 data type이 올 경우
                //1.implicit bool 연산 적용 시도
                //위 코드에서 explicit>implicit으로 바꾸면 먼저 적용됨
                //2.Xbool data class의 true operator 적용 시도
                //3.Xbool data class의 false operator 적용 시도
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.WriteLine((bool)xb);
            // invoke conversion-operator bool

            //Xbool.bool 하면 error
            //boolean class의 ToString연산 적용해서 화면에 출력

            //Console.WriteLine(xb);
            //하면 위에 implicit일 경우 그게 출력되는데 왜일까
            //explict일 경우에는 클래스 이름 출력

        }
    }
}

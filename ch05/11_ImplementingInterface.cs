using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingInterfaceApp
{
    interface IRectangle
    {
        void Area(int width, int height);//구현 X
    }
    interface ITriangle
    {
        void Area(int width, int height);
    }
    class Shape : IRectangle, ITriangle
    {
        void IRectangle.Area(int width, int height)
        {//interfaceName.func
            Console.WriteLine("Rectangle Area : " + width * height);
        }
        void ITriangle.Area(int width, int height)
        {
            Console.WriteLine("Triangle Area : " + width * height / 2);
        }
        //다 구현 안해놓으면 추상 클래스가 됨
    }
    class Program
    {
        public static void Main()
        {
            Shape s = new Shape();
            // s.Area(10, 10);             // error - ambiguous !!!
            // s.IRectangle.Area(10, 10);  // error
            // s.ITriangle.Area(10, 10);   // error

            //s입장에서는 Area만 있음
            ((IRectangle)s).Area(20, 20);  // 캐스팅-업
            //interface로 casting up 해서 불러야한다.
            ((ITriangle)s).Area(20, 20);   // 캐스팅-업
            IRectangle r = s;              // 인터페이스로 캐스팅-업
            ITriangle t = s;               // 인터페이스로 캐스팅-업
            //인터페이스 타입으로 객체 생성해서 함수 부를 수도 있음
            r.Area(30, 30);
            t.Area(30, 30);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodApp
{
    class BaseClass
    {
        virtual public void MethodA()
        {
            Console.WriteLine("Base MethodA");
        }
        virtual public void MethodB()
        {
            Console.WriteLine("Base MethodB");
        }
        virtual public void MethodC()
        {
            Console.WriteLine("Base MethodC");
        }
    }
    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {//baseclass의 methodA hiding, object type에 따라 어떤 method호출할 것인지 결정
            Console.WriteLine("Derived MethodA");
        }
        override public void MethodB()
        {//virtual로 선언되어있을때에만 override 가능
            //논리적으로 있기는 한데, 덮어씀 어떤 객체 type으로 불러도 안보임
            //base.MethodB()로 하면 부를 수 있음
            Console.WriteLine("Derived MethodB");
        }
        public void MethodC()
        {//Hiding
            Console.WriteLine("Derived MethodC");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass s = new DerivedClass();//Baseclass 객체 type
            //묵시적 형 변환 이루어짐
            s.MethodA();//baseClass의 methodA
            s.MethodB();//override > 실제 어떤 객체이냐가 중요, derivedClass의 methodB호출
            s.MethodC();
            //baseclass에 methodC가 없다면, 실행 불가
        }
    }
}

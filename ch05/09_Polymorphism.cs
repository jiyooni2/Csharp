using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismApp
{
    class BaseClass
    {
        public virtual void Output()//파생클라스에서 재정의 할 수 도 있음을 암시 
        {
            Console.WriteLine("In the Base class ...");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Output()
        {
            Console.WriteLine("In the Derived class ...");
        }
    }
    class Program
    {
        static void Print(BaseClass obj)
        {
            obj.Output();
        }
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass();
            DerivedClass obj2 = new DerivedClass();//DerivedClass가 BaseClass로 묵시적 형변환 이루어짐(print param으로 넘어가면서)
            BaseClass obj3 = new DerivedClass();//묵시적 형 변환 이루어짐.
            //Derived Class는 BaseClass의 Output부분을 자신의 것으로 덮어씌어버림
            Print(obj1);//BaseClass의 Output
            Print(obj2);//DerivedClass의 Output
            //Print안에서 BaseClass로 묵시적 형변환이 되어도 override니까 덮어씌움
            Print(obj3);//DerivedClass의 Output, override니까, 덮어씌움

            //new였으면 셋다 in the base..나옴
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApp
{
    abstract class AbstractClass//abstract class
    {
        public abstract void MethodA();//일부 method는 구현이 안되어있고 선언만 있음
        public void MethodB()
        {
            Console.WriteLine("Implementation of MethodB()");
        }
    }
    class ImpClass : AbstractClass
    {
        override public void MethodA()
        {
            Console.WriteLine("Implementation of MethodA()");
        }//이제 모든 method가 구현되었으니 객체 생성 가능
    }
    class Program
    {
        static void Main(string[] args)
        {
            ImpClass obj = new ImpClass();
            obj.MethodA();
            obj.MethodB();
        }
    }
}


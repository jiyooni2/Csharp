using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingAndOverloadingApp
{
    class BaseClass
    {
        public void MethodA()
        {
            Console.WriteLine("In the BaseClass ...");
        }
    }
    class DerivedClass : BaseClass
    {
        new public void MethodA()//signature가 같음, new로 재정의
            //new없어도 되기는 하며 baseclass의 methodA는 hiding되어있음
        {             // Method Redifinition, Hiding
            Console.WriteLine("In DerivedClass ... Overriding !!!");
            base.MethodA();//명시적으로 baseclass의 methodA도 호출 가능, Hidiing일 뿐 없는것 아님
        }
        public void MethodA(int i)//signature가 다르니까 결국 다른 method이고, overloading
        {           // Overloading
            Console.WriteLine("In DerivedClass ... Overloading !!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass();
            DerivedClass obj2 = new DerivedClass();
            BaseClass obj3;
            obj1.MethodA();
            obj2.MethodA();//redefinition됨 Method 호출됨
            obj2.MethodA(1);
            obj3 = (BaseClass)obj2;//upcasting 가능
            obj3.MethodA();//Baseclass처럼 보겠다 이므로, BaseClass의 methodA가 호출됨
            //객체 타입에 따라 어떤 method가 호출 될지 결정된다!!, methodA....
        }
    }
}


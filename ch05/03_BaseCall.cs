using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseCallApp
{
    class BaseClass
    {
        public int a, b;
        public BaseClass()
        {
            a = 1; b = 1;
        }
        public BaseClass(int a, int b)
        {
            this.a = a; this.b = b;//this는 class나 객체 자기자신, BaseClass.a
        }//생성자 함수 overloading 되어서 또 있음
    }
    class DerivedClass : BaseClass
    {
        public int c;
        public DerivedClass()//:base() 
                             //기본 생성자 상속함(default)
        {
            c = 1;
        }
        public DerivedClass(int a, int b, int c)
            : base(a, b)
        {
            this.c = c;
        }
        //argument가 (int a,int b)인 생성자 호출
        //base(a,b)가 먼저 호출됨

    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj1 = new DerivedClass();

            DerivedClass obj2 = new DerivedClass(1, 2, 3);
            Console.WriteLine("a = {0}, b = {1}, c = {2}",
                obj1.a, obj1.b, obj1.c);
            Console.WriteLine("a = {0}, b = {1}, c = {2}",
                obj2.a, obj2.b, obj2.c);
        }
    }
}
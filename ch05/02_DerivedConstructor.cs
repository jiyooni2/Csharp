using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedConstructorApp
{
    class BaseClass
    {
        public BaseClass()//생성자 함수는 class와 이름이 같아야 한다.
        {
            Console.WriteLine("BaseClass Constructor ...");
        }
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass()
        {
            Console.WriteLine("DerivedClass Constructor ...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            //1.field 초기화
            //2.BaseClass 생성자(생성자 내에서 초기화할것있으면 하고)
            //3.derivedclass 생성자
            Console.WriteLine("In the main ...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddendumApp
{
    class BaseClass
    {
        public void MethodA()
        {
            Console.WriteLine("do BaseClass Task.");
        }
    }
    class DerivedClass : BaseClass
    {
        new public void MethodA()
        {//methodA 재정의,hiding
            base.MethodA();//methodA가 하는 짓 그대로 다 함
            Console.WriteLine("do DerivedClass Task.");
            //plus alpha로 또 무언가를 함
            //점진적으로 설계
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.MethodA();
        }
    }
}

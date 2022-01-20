using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingApp
{
    class MethodOverloading
    {
        public void SomeThing()// void_MO_SomeThing = signature
            //실제 함수 이름은 compiler에 signature로 들어가고, 
            //함수 호출 인자 보고 signature 찾아서 실행
        {
            Console.WriteLine("SomeThing() is called.");
        }
        public void SomeThing(int i)// void_MO_SomeThing_int
        {
            Console.WriteLine("SomeThing(int) is called.");
        }
        public void SomeThing(int i, int j)// void_MO_SomeThing_int_int
        {
            Console.WriteLine("SomeThing(int,int) is called.");
        }
        public void SomeThing(double d)// void_MO_SomeThing_double
        {
            Console.WriteLine("SomeThing(double) is called.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MethodOverloading obj = new MethodOverloading();
            obj.SomeThing();
            obj.SomeThing(526);
            obj.SomeThing(54, 526);
            obj.SomeThing(5.26);//똑같은 시그니처 찾고 없으면
            //묵시적 형 변환, float이면 double로 변환해서 ㄱㄱ
        }
    }
}

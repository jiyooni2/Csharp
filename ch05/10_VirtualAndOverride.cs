using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndOverrideApp
{
    class CLanguage
    {
        /*virtual public void Print()
        {
            Console.WriteLine("In the Clanguage class ...");
        }*/
        override public void Print()
        {
            Console.WriteLine("In the Java class ...");
        }//이런느낌
    }
    class Java : CLanguage
    {
        override public void Print()
        {
            Console.WriteLine("In the Java class ...");
        }//C의 Print덮어씌움
    }
    class Program
    {
        static void Main(string[] args)
        {
            CLanguage c = new Java();//C type으로 묵시적 형 변환을 이루어도
            c.Print();//이미 덮어씌워졌으니, Java의 print가 호출됨
        }
    }
}

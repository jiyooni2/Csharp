using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    class StringApp { }

    class Program
    {
        static void Main(string[] args)
        {
            StringApp obj = new StringApp();
            string str = "Class name is ";
            //string은 객체
            //""를 이용해서 string객체 생성
            //string str=new string("Class name is ");
            Console.WriteLine(str + obj.ToString());

            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Append(obj.ToString());
            Console.WriteLine(sb);
        }
    }
}

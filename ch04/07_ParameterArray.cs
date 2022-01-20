using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterArrayApp
{
    class Program
    {
        static void ParameterArray(params object[] obj)
        //여기서 그냥 void라고하면 Main에서 사용불가
        //이 method는 객체 생성전까지 없는 method
        {
            for (int i = 0; i < obj.Length; i++)
                //obj는 Array니까, Length property 존재
                Console.WriteLine(obj[i]);
        }
        static void Main(string[] args)
        {
            ParameterArray(123, "Hello", true, 'A');
        }
    }
}

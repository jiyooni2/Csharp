using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivByZeroExceptionApp
{
    class Program
    {
        public static void Main()
        {
            int i = 1, j = 0, k;
            try
            {
                k = i / j;
            }
            catch (Exception)
            {
                Console.WriteLine("ㅈ됫다");
                //Exception이 발생하면 catch로 제어 넘어감
            }
            k = i / j;
            //CLR이 처리 -> 예외문 print해주겠지
        }
    }
}

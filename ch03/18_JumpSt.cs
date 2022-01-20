using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpStApp
{
    class Program
    {
        static int sum(int s, int i)
        {
            return s + i;
        }
        static void Main(string[] args)
        {
            int n, s, i;
            for (; ; )
            {
                Console.Write("Enter a number : ");
                n = Int32.Parse(Console.ReadLine());//파싱해서 32bit integer만드는 것
                                                    //string으로 읽어들여서 int32.parse에게 넘김
                                                    //숫자문자열을 파싱해서 integer로 바꿈(숫자문자열를 입력값으로 줘야함)

                //이러면 -4넣어도  한 문자만 읽는게 아니라 int32 value를 가지고감
                if (n == 0) break;//반드시 break문 있어야 한다
                else if (n < 0) continue;
                for (s = 0, i = 1; i <= n; ++i)
                    s = sum(s, i);//sum(s,i)에 return 값이 대치된다.
                Console.WriteLine("n = {0}, sum = {1}", n, s);
            }
            Console.WriteLine("End of Main");
        }
    }
}

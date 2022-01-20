using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemExThrowApp
{
    class SystemExThrow
    {
        public static void Exp(int ptr)
        {
            //여기 안에서 try catch도 가능
            //둘 다 있다면 여기가 먼저 실행
            if (ptr == 0)
                throw new NullReferenceException();
            //NullRefernceException 던져버림
            //method내에도 try catch 없고, return해서도 없으니까
            //CLR이 처리
        }
    }
    class Program
    {
        public static void Main()
        {
            int i = 0;
            SystemExThrow.Exp(i);
            //다른 클래스의 static method니까
        }
    }
}

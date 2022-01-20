using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserHandlerApp
{
    class UserExceptionOne : ApplicationException { }
    //아무것도 안해도 msg저장하는 string있음
    class UserExceptionTwo : ApplicationException { }
    class Program
    {
        static void Method(int i)
        {
            if (i == 1) throw new UserExceptionOne();
            else throw new UserExceptionTwo();
        }
        public static void Main()
        {
            try
            {
                Console.WriteLine("Here: 1");
                Method(2);//User Exception Two
                Console.WriteLine("Here: 2");
            }
            catch (UserExceptionOne)
            {
                Console.WriteLine("UserExceptionOne is occurred!!!");
            }
            catch (UserExceptionTwo e)
            {
                Console.Write(e.Message);
                Console.WriteLine("UserExceptionTwo is occurred!!!");
                //여기서 예외처리 한 다음에
            }
            Console.WriteLine("Here: 3");
            //예외를 처리 했으니까 그 다음문장 이어서 정상 실행
        }
    }
}

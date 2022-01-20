using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExceptionApp
{
    class UserErrException : ApplicationException
    {
        public UserErrException(string s) : base(s) { }
        //string s를 param으로 전달받으면,
        //이 method는 부모를 상속한 method
        //ApplicationException(string s)를 호출해줌
        //부모의 상속자 호출
        //ApplicationException(string s)는 instance의 message를 string s 로 init
    }

    class Program
    {
        public static void Main()
        {
            try//error발생 가능성 O
            {
                throw new UserErrException("throw a exception with a message");
                //Exception객체를 생성시켜서 던짐
            }
            catch (UserErrException e)
            //UserErrException이 던져지면, catch해서 여기서 생성(제어 넘어감)
            {
                Console.WriteLine(e.Message);
                //모든 exception에는 Message field가 있음
            }
        }
    }
}

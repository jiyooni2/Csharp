using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgExceptionApp
{
    class MyException : ApplicationException
    {
        public int value;
        public MyException() { }
        public MyException(string msg, int i)
            : base(msg)
        {
            value = i;//거기에다가 이거 기능 추가
        }
        //base클래스(ApplicationException)의 string param으로 받는 생성자 상속
        //msg를 ApplicationException의 Message 필드에 저장 
    }
    class Program
    {
        static void F(int k)
        {
            if (k < 70 || k > 100)
                throw new MyException();
        }
        static void G(int k)
        {
            if (k > 200)
                throw new MyException("Too Many", k);
            if (k < 50)
                throw new MyException("Too Less", k);
        }
        public static void Main()
        {
            try
            {
                F(50);
                //throw new MyException
                //F method 정의된 곳에 올라가서 없으니까 여기서 실행
            }
            catch (MyException e)
            {
                Console.WriteLine(e.StackTrace);
                //e.StackTrace : 어떤식으로
            }

            try
            {
                G(250);
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
                //Too Many
                Console.WriteLine(e.StackTrace);
                //어떤식으로 메소드 호출했는지 호출 순서 기록되어있음
                Console.WriteLine("Data value is {0}.", e.value);
            }
        }
    }
}

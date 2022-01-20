using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserExThrowApp
{
    class UserException : ApplicationException { }
    class Program
    {
        static void Method()
        {
            throw new UserException();
            //2. throw
            //catch문 검사 여기에 있는지 먼저 check(1)
        }
        public static void Main()
        {
            try
            {
                Console.WriteLine("Here: 1");
                Method();
                //1.호출한 곳으로 올라감
                //catch문 여기에 있는지 check(2)
                Console.WriteLine("Here: 2");
            }
            catch (UserException)
            {
                Console.WriteLine("User-defined Exception");
            }
        }
    }
}

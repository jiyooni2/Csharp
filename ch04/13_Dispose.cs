using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeApp
{
    class DisposeClass : IDisposable//IDisposalbe interfacee 상속
    {
        // ...
        public void Dispose()
        {//반드시 dispose method 정의해야함
            Console.WriteLine("In the Dispose ...");
            GC.SuppressFinalize(this);//GC해줄 필요 없음
            //CLR가 GC하지 않고 바로 dispose 해버림
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            using (DisposeClass obj = new DisposeClass())
            {
                // ...
            }
            //객체 자원 사용시 이 안에서만 사용하고 사용 후 곧바로 다 반납
            //using문 끝나면 dispose불러서 바로 없애버림
            Console.WriteLine("End of Main");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadIntegerApp
{
    class Program
    {
        static int ReadInt()
        {
            char ch;
            int n = 0;
            while (!char.IsDigit(ch = (char)Console.Read())) ;
            //ch의 첫글자가 숫자가 아닐때까지 while
            //ch가 첫글자가 숫자면 다음코드로 진행
            do
            {
                n = n * 10 + (ch - '0');
                //n의 뒤에 ch를 push
                //4578입력했으면
                //4(첫번째 입력부터 Console.read니까)
                //45
                //457
                //4578
                ch = (char)Console.Read();
            } while (char.IsDigit(ch));
            //읽은 추가적인 숫자가 숫자이면, 반복
            //4A65이면 4 65 print(빠져나옴)
            //A일때 빠져나오고 
            //다음 문자 6 또 진행

            //어떤 문자를 넣던간에, 그중 int 2개를 추출
            return n;
        }
        static void Main(string[] args)
        {
            Console.Write("*** input data : ");
            Console.WriteLine("*** read data : " + ReadInt() + " " + ReadInt());
        }
    }
}
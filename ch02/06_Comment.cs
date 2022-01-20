using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            char ch;
            Console.Write("Enter a super digit : "); // prompt message
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case 'E':
                case 'F':
                    value = ch - 'A' + 10;
                    //셋 다 정수형 상수니까
                    //제일 큰 형태인 int로 바꾸어 연산
                    //unicode값+int-unicode값
                    //unicode값-unicode값+int
                    //이 상황에서도 (int)0+int 가 됨
                    break;
                case 'a':
                case 'b':
                case 'c':
                case 'd':
                case 'e':
                case 'f':
                    value = ch - 'a' + 10; // code value => binary value
                    break;
                default:
                    Console.WriteLine(ch + " is not a hexadigit");
                    break;
            }  // end of switch
            Console.WriteLine(value);
        }
    }
}

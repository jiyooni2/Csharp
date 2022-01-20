using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day number 1 ~ 7 : ");
            int day = Console.Read() - '0';
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    //case하고 1 사이는 붙힘
                    break;
                //모든 case뒤에는 break
                case 2: Console.WriteLine("Monday"); break;
                case 3: Console.WriteLine("Tuesday"); break;
                case 4: Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Thursday"); break;
                case 6: Console.WriteLine("Friday"); break;
                case 7: Console.WriteLine("Saturday"); break;
                default: Console.WriteLine("Illegal day"); break;
                    //다 아닐경우에 실행
                    //default도 break
                    //break안쓰면 switch문에서 빠져나오질 못함
                    //C처럼 뭐 못함
                    //다른 case로 중첩해서 처리하려면 goto문 사용해야함
            }
        }
    }
}

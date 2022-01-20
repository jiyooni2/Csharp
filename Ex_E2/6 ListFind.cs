using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListFind
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("abc");
            list.Add("edf");
            list.Add("123");

            //string result = list.Find(

            //    (string a) =>
            //    {
            //        return a == "abc";
            //    }

            //    );

            //무명 델리게이트 또는 람다식 사용
            string result = list.Find(
                delegate (string a)
                {
                    return a == "abc";
                }
            );
            //Find의 argument 로 delegate 전달해야함
            //찾고자 하는 것에 대해서 true를 return하는 델리게이트 선언해야함
            //true이면 찾은 것



            Console.WriteLine(result);
        }
    }
}

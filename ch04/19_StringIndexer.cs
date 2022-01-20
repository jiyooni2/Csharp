using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexerApp
{
    class StringIndexer
    {
        public char this[string str, int index]
        {
            //char return이니까 char
            get { return str[index]; }
        }
        public string this[string str, int index, int len]
        //string return이니까 string
        {
            get { return str.Substring(index, len); }
            //index부터 len까지 substring을 만들어서 return
            //substring 별도의 객체가 만들어지는 것임
            //이런식으로, str에 여러가지 방식으로 접근 가능
        }
    }
    class Program
    {
        public static void Main()
        {
            string str = "Hello";
            StringIndexer s = new StringIndexer();
            for (int i = 0; i < str.Length; i++)
                Console.WriteLine("{0}[{1}] = {2}", str, i, s[str, i]);
            //s[str,i] = s.str[i]
            //근데 이거 막 쳐바꿔도 되나?
            //ㅇㅇ 됨
            Console.WriteLine("Substring of {0} is {1}", str, s[str, 2, 3]);
            //3번째 argument 자리를 str.Substring()코드가 이 자리를 차지함
            //str과 전혀 다른 별도의 객체를 만든다음에 그걸 return 하는 것<기억하기!>
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyWithoutFieldApp
{
    class PropertyWithoutField
    {
        public string Message
        {
            get { return Console.ReadLine(); }
            set { Console.WriteLine(value); }
        }
    }
    class Program
    {
        public static void Main()
        {
            PropertyWithoutField obj = new PropertyWithoutField();
            obj.Message = obj.Message;
            //set=get;
            //Console.WriteLine(Console.ReadLine())
            //오른쪽부터 실행되니까, get 이후 set
            //Console.ReadLine()이후,
            //ReadLine한 값을 set에서 value로 넣음
        }
    }
}

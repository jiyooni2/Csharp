using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWOnlyPropertyApp
{
    class RWOnlyProperty
    {
        private int readOnlyField = 100;
        private int writeOnlyField;
        public int ReadOnlyProperty
        {
            get
            {
                Console.WriteLine("In the ReadOnlyProperty ...");
                return readOnlyField;
            }
        }
        public int WriteOnlyProperty
        {
            set
            {
                Console.WriteLine("In the WriteOnlyProperty ...");
                writeOnlyField = value;
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            RWOnlyProperty obj = new RWOnlyProperty();
            obj.WriteOnlyProperty = obj.ReadOnlyProperty;//set=get;
            //get먼저 불린 다음 set불림
            //실제로 실행하면 in the read>in the write
            Console.WriteLine("value = " + obj.writeOnlyField); // Compile Error
            //equal 연산자의 왼쪽이나 오른쪽에 있는게 아닌
            //혼자 있으면 get이 호출되는데, get이 없으므로 compile error 발생
            //private하니까, 단순 print도 안됨!!
        }
    }
}

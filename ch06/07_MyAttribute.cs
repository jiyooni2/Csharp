using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAttributeApp
{
    public class MyAttrAttribute : Attribute
    {   // 속성 클래스

        public MyAttrAttribute(string message)
        { // 생성자

            this.message = message;
        }
        private string message;
        public string Message
        {                  // 프로퍼티
            get { return message; }
        }
    }

    [MyAttr("This is Attribute test.")]
    //여기서 생성자 this.message = "~"로 set된것
    class Program
    {
        public static void Main()
        {
            Type type = typeof(Program);
            //typeof(Program)을 하면
            //Program의 type 객체를 return

            object[] arr = type.GetCustomAttributes(typeof(MyAttrAttribute), true);
            //customAttribute의 array를 return해줌

            if (arr.Length == 0)
                Console.WriteLine("This class has no custom attrs.");
            else
            {
                MyAttrAttribute ma = (MyAttrAttribute)arr[0];
                //arr[0]에는 customAttribute가 들어있고  
                //arr[0]은 boxing되어 있으니까,
                //원래의 type으로 unboxing 해줘야함!    
                Console.WriteLine(ma.Message);
            }
        }
    }
}

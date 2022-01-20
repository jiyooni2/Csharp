using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsoleteAttrApp
{
    class ObsoleteAttr
    {
        [Obsolete("경고, Obsolete Method입니다.")]
        //이미시스템에 정의 되어있어서 실행되고 호출도되지만
        //컴파일 시 Warning
        //컴파일 보면, 다른 메소드 사용하려고 할것임
        public static void OldMethod()
        {
            Console.WriteLine("In the Old Method ...");
        }
        public static void NormalMethod()
        {
            Console.WriteLine("In the Normal Method ...");
        }
    }
    class Program
    {
        public static void Main()
        {
            ObsoleteAttr.OldMethod();
            ObsoleteAttr.NormalMethod();
        }
    }
}

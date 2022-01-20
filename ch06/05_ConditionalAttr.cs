#define CSHARP
//#define JAVA
//using전에 작성해야한다


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConditionalAttrApp
{
    class ConditionalAttr
    {
        [Conditional("CSHARP")]//속성을 정의하고하는 메소드나 필드 바로위에
        //CSHARP가 정의되어있으면 이걸 컴파일
        public static void CsharpMethod()
        {
            Console.WriteLine("In the CSharp Method ...");
        }
        [Conditional("JAVA")]
        //JAVA가 정의되어있으면 이걸 컴파일, 코드는 존재하지면 실제론 실행되지않음
        public static void JavaMethod()
        {
            Console.WriteLine("In the Java Method ...");
        }
    }

    class Program
    {
        public static void Main()
        {
            ConditionalAttr.CsharpMethod();
            //객체가 생성되지 않아도 어셈블리에 메타데이터 형식으로 저장됨
            //그래서 그냥 바로 클라스 소속으로 호출 가능
            ConditionalAttr.JavaMethod();
        }
    }
}

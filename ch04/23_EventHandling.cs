using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingApp
{
    public delegate void MyEventHandler();                      // 1. 이벤트를 위한 델리게이트 정의
    //미리 정의해야함!!
    class Button
    {
        public event MyEventHandler Push;                       // 2. 이벤트 선언
        //modifier event DelegateType name;
        public void OnPush()
        {
            if (Push != null)
                Push();                                         // 5. 이벤트 발생
        }
    }
    class EventHandlerClass
    {
        public void MyMethod()                                  // 3. 이벤트 처리기 작성
        {//델리게이트 형태가 param이 없으므로,
         //param이 없는 method만 event에 연결 가능
            Console.WriteLine("In the EventHandlerClass.MyMethod ...");
        }
    }
    class Program
    {
        public static void Main()
        {
            Button button = new Button();
            EventHandlerClass obj = new EventHandlerClass();
            //button객체와 eventhandler 객체 생성
            button.Push += new MyEventHandler(obj.MyMethod);    // 4. 등록
            //Event 처리기를 등록, Evnet객체 생성

            //이벤트 객체에 이벤트 헨들러 연결
            //객체의 외부에서, method setting
            button.OnPush();
            //push가 비지 않았으므로 push함
            //연결 안되어있으면 null
            //button.Push()해도 못부름(Event라서)
            //호출은 내부에서 setting은 외부에서
            //이게 Event기본개념
        }
    }
}

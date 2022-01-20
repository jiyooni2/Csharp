using System;
using System.Collections;

namespace Enumerable
{
    class A { }
    class Program
    {
        private List<A> list = new List<A>();
        //generic A obj만들어서 add

        public static void funcA()
        {
            A a = new A();
            list.Add(a);
            //A객체를 새로 생성해서 만들것인지
            //아니면 a를 그대로 넣을것인지
            //내가 넘겨준 obj를 copy해서 list에 넣는지
            //확실하지 않음
            //A가 class가 아니라 struct일경우, 값형이므로 블럭에서 빠져나오면 사라짐
            //그거를 list.Add하면, struct A를 넣으면 main으로 가면 사라져야됨
            //그게 리스트에 유지되면 안되겠지
            //독자적으로 A를 위한걸 만들어놓고 copy를 하는 방식이면 문제가 없겠지
            //추측으로는 value type의 경우에는 스스로 따로 만들지 않을까
            //obj라면 둘다 괜찮지만, list.Add코드를 확인해봐야함..
        }



        public static void Main()
        {

        }
    }
}

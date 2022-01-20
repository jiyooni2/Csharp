using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoundedGenericApp
{
    class GenericType<T> where T : SystemException
        //SystemException을 상속받은 datatype만 T로 가능하다
    {
        private T value;//객체 포인터, 객체 자체는 아님

        public GenericType(T v)
        {
            value = v;//받으면 포인터가 v를 가르킴
        }

        override public String ToString()
        {
            return "Type is " + value.GetType();
            //변수의 datatype return
        }
    }

    public class Program
    {
        public static void Main()
        {
            GenericType<NullReferenceException> gNullEx
                = new GenericType<NullReferenceException>(new NullReferenceException());
            GenericType<IndexOutOfRangeException> gIndexEx
                = new GenericType<IndexOutOfRangeException>(new IndexOutOfRangeException());
            //Exception객체 생성해서 생성자에 넣어줘야겠지
            //위에서 객체를 생성자로 받았으니까


            // GenericType<String> gString = new GenericType<String>("Error"); //에러

            Console.WriteLine(gNullEx.ToString());
            Console.WriteLine(gIndexEx.ToString());
            //ToString은 빼도 됨
        }
    }
}
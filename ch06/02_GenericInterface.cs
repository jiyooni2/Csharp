using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaceApp
{
    interface IGenericInterface<T>
    {
        void setValue(T x);
        string getValueType();
    }

    class GenericClass<T> : IGenericInterface<T> {
        private T value;
        public void setValue(T x) {
            value = x;
        }

        public string getValueType() {
            return value.GetType().ToString();
            //모든 타입마다 GetType()은 있음(클래스마다도)
            //GetType() : return data type
            //ToString() : return string
        }
    }

    public class Program
    {
        public static void Main()
        {
            GenericClass<Int32> gInteger = new GenericClass<Int32>();
            GenericClass<String> gString = new GenericClass<String>();

            gInteger.setValue(10);
            gString.setValue("Text");

            Console.WriteLine(gInteger.getValueType());
            Console.WriteLine(gString.getValueType());
        }
    }
}
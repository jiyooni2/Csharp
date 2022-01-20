using System;

namespace ConstraintsOnTypeParameters
{
    class StructArray<T> where T : struct
    {
        public T[] Array { get; set; }
        //자동구현 property
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }

    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
        //class BaseArray<T> where T : Base도 같은 것
        //U는 Base거나, Base를 상속받은 것
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }

        public void CopyArray<T>(T[] Target) where T : U
            //포유류로부터 파생된 개,고양이 등등에서 다 동작한다는 의미
        {//T는 U로부터 파생된 클래스여야 한다
            Target.CopyTo(Array, 0);
            //Array는 property
            //Array마다 CopyTo method 있음 datacopy해줌 
            //0번째 element부터 copy
        }
    }

    class MainApp
    {
        public static T CreateInstance<T>() where T : new()
            //T는 매개변수가 없는 생성자

            //return type : T, param : no

            //T type받아서, 매개변수 없는 T객체 생성자 호출해서 객체를 return
        {
            return new T();
        }

        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            //자동구현 property 사용(인덱서는 자신의이름 사용)
            a.Array[0] = 0;//public이니까
            a.Array[1] = 1;
            a.Array[2] = 2;

            for (int i = 0; i < a.Array.Length; i++)
            {
                //자동구현 property, a.Array하면 get
                //Array를 get하니까, Array의 Length property 사용 가능
                Console.WriteLine(a.Array[i]);
            }

            //< > 안은 객체
            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            //RefArray의 datatype으로 StructArray
            //generic의 datatype으로 generic을 줄 수 있으니까

            //RefArray의 datatype은 double형을 가진 StructArray

            b.Array[0] = new StructArray<double>(5);
            //StructArray 객체들을 가르키는 array가 생성되고, 그안에
            //StructArray 객체들(double형의 size 5인 배열)이 들어감
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);
            //위에서 생성할때 size 3으로 만들었으니까 0~2



            BaseArray<Base> c = new BaseArray<Base>(3);
            //Base타입의 Array
            //< > :Base나 Base의 파생 class만
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            //c.Array[1]은 Base타입 객체
            //Base타입에 derived를 할당,
            //upcasting은 묵시적 가능
            //base 상속받아서 derived.
            //포유류->사람 가르킬 수 있음
            c.Array[2] = CreateInstance<Base>();
            //Base는 매개변수가 없는 생성자가 있어야 한다.

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived(); // Base 형식은 여기에 할당 할 수 없다.
            //d.Array[0] = new Base(); //명시적으로 casting해줘야지만 구현 가능
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();
            //Dervied는 매개변수가 없는 생성자가 있어야 한다

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);
            //d의 내용을 e로 copy

            for (int i = 0; i < e.Array.Length; i++)
                Console.WriteLine(e.Array[i]);//내용 없는것 넣어서 그럼
            for (int i = 0; i < d.Array.Length; i++)
                Console.WriteLine(d.Array[i]);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedTypeConversionApp
{
    class Mile
    {
        public double distance;
        public Mile(double distance)
        {
            this.distance = distance;
        }
        // Mile operator: double to Mile
        public static implicit operator Mile(double d)
        {//Mile class가 있으니까 Mile data type으로 형 변환이 가능하니까
            Mile m = new Mile(d);
            return m;
        }
        // Kilometer operator: Mile to Kilometer
        public static explicit operator Kilometer(Mile m)
        {
            return m.distance * 1.609;
        }
    }
    class Kilometer
    {
        public double distance;
        public Kilometer(double distance)
        {
            this.distance = distance;
        }
        // Kilometer operator: double to Kilo
        public static implicit operator Kilometer(double d)
        {
            Kilometer k = new Kilometer(d);
            return k;
        }
        // Mile operator: Kilo to Mile
        public static explicit operator Mile(Kilometer k)
        {
            return k.distance / 1.609;
        }
    }
    class Program
    {
        public static void Main()
        {
            Kilometer k = new Kilometer(100.0);
            Mile m;

            m = (Mile)k;//kilometer class의 explict operator Mile
                        //return double value

            //double형을 묵시적으로 Mile type으로 바꾸는 연산이 Mile에 정의되어있음


            //Mile 객체에 double이 옴
            //묵시적 형 변환, 왼쪽의 데이터로 묵시적 형 변환 하려고함
            //(implicit Mile)double
            //불가능하면 error
            //int에 double넣는것 생각하면 됨
            Console.WriteLine("{0} km = {1} mile", k.distance, m.distance);

            m = 65.0;
            //m = (implicit mile) 65.0
            //m = mile_object(dist=65.0)
            k = (Kilometer)m;
            //kilo_obj=(explicit kilo)mile_obj
            //kilo_obj=double
            //kilo_obj=(implicit kilo)double
            Console.WriteLine("{0} mile = {1} km", m.distance, k.distance);
        }
    }
}

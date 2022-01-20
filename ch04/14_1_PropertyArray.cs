using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class Fraction
    {
        private int numerator;
        private int denominator;
        private int[] array;
        //array는 property로 정의하려면
        //1.array를 property로 사용
        //2.indexer 사용

        public Fraction(int size)
        {
            array = new int[size];
        }
        public int[] Array
        {
            get { return array; }
            set { array = value; }
        }//index 넣지 말고 그냥 array=value함
        //존나 주의하세요
        //Array를 오른쪽에두면 return되는데,
        //이경우에는 Array가 통째로 복사됨 
        //프로퍼티가아닌 그냥 배열도 통째로복사
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        override public string ToString()
        {
            return (numerator + "/" + denominator);
        }
    }
    class Program
    {
        public static void Main()
        {
            Fraction f = new Fraction(3);
            //Fraction f= new Fraction() error
            //생성자 생성하면 기본 생성자도 만들어줘야함
            int i;
            f.Numerator = 1;   // invoke set-accessor in Numerator
            i = f.Numerator + 1; // invoke get-accessor in Numerator
            f.Denominator = i; // invoke set-accessor in Denominator
            Console.WriteLine(f.ToString());
            //Console.WriteLine(f); return same result
            for (i = 0; i < f.Array.Length; i++)
            {
                //Array는 array를 대표하는 property
                //return array니까 array.Length가 나오는거임

                f.Array[i] = i;//왼쪽이니까 set
                Console.Write(f.Array[i] + " ");
                //Array가 return array니까 array[i]가 나오는것
            }
        }
    }
}

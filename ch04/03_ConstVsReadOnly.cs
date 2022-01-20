using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVsReadOnlyApp
{
    public class Color
    {
        public const int FULL = 0xFF;              // constant member
        public const int EMPTY = 0x00;             // constant member
        private byte red, green, blue;//0~255니까 byte사용
        // readonly fields
        public static readonly Color Red = new Color(FULL, EMPTY, EMPTY);
        public static readonly Color Green = new Color(EMPTY, FULL, EMPTY);
        public static readonly Color Blue = new Color(EMPTY, EMPTY, FULL);
        //자기 자신 객체를 가르키는 pointer도 선언 가능
        //static, 초기화 set도 가능
        
        public Color(byte r, byte g, byte b)
        {     // constructor
            red = r;
            green = g;
            blue = b;
        }
        public static void PrintColor(Color c)
        {   // static method
            Console.WriteLine("red value={0}, green value={1}, blue value={2}",
                c.red, c.green, c.blue);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FULL = " + Color.FULL);
            Color.PrintColor(Color.Red);
            //static 이므로 method 호출 가능
        }
    }
}
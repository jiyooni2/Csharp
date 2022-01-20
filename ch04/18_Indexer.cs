using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerApp
{
    class Color
    {
        private string[] color = new string[5];
        //string[5] 객체를 만들며 color가 가르키게 한다.
        public string this[int index]
        {
            get { return color[index]; }
            set { color[index] = value; }
        }
    }
    class Program
    {
        public static void Main()
        {
            Color c = new Color();
            c[0] = "WHITE";
            //객체이름에 배열 기호 this[index]
            //이런 식으로 쓰니까, this 지정어 사용
            c[1] = "RED";
            //c.color[1]="RED"랑 같은 의미
            //c[1]=c.color[1]
            c[2] = "YELLOW";
            c[3] = "BLUE";
            c[4] = "BLACK";
            for (int i = 0; i < 5; i++)
                Console.WriteLine("Color is " + c[i]);
        }
    }
}

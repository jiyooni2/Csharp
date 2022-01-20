using System;
using System.IO;

namespace TextFile
{
    class MainApp
    {
        static void Main(string[] args)
        {
            StreamWriter sw =
                new StreamWriter(
                    new FileStream("a.txt", FileMode.Create));

            sw.WriteLine(int.MaxValue);
            //int넘기면 text로 변환해서 write해줌
            sw.WriteLine("Good morning!");
            sw.WriteLine(uint.MaxValue);
            sw.WriteLine("안녕하세요!");
            sw.WriteLine(double.MaxValue);

            sw.Close();

            StreamReader sr =
                new StreamReader(
                    new FileStream("a.txt", FileMode.Open));

            Console.WriteLine("File size : {0} bytes", sr.BaseStream.Length);
            //읽을때도 pointer있는데, 끝에 도달하면 sr.EndOfStream이 true가 됨
            while (sr.EndOfStream == false)
            //sr.EndOfStream
            {
                Console.WriteLine(sr.ReadLine());
            }

            sr.Close();
        }
    }
}

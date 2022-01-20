using System;
using System.IO;

namespace BinaryFile
{
    class MainApp
    {
        static void Main(string[] args)
        {
            BinaryWriter bw =
                new BinaryWriter(
                    new FileStream("a.dat", FileMode.Create));
            //FileStream을 input으로
            //알아서 변환시켜줌 뭘 주던간에

            bw.Write(int.MaxValue);
            bw.Write("Good morning!");
            bw.Write(uint.MaxValue);
            bw.Write("안녕하세요!");
            bw.Write(double.MaxValue);

            bw.Close();

            BinaryReader br =
                new BinaryReader(
                    new FileStream("a.dat", FileMode.Open));

            Console.WriteLine("File size : {0} bytes", br.BaseStream.Length);
            Console.WriteLine("{0}", br.ReadInt32());
            //넣은 순서대로 해야됨 ReadInt
            Console.WriteLine("{0}", br.ReadString());
            //Length저장하고 string저장해서 그냥 잘 읽어옴, 적힌만큼
            Console.WriteLine("{0}", br.ReadUInt32());
            Console.WriteLine("{0}", br.ReadString());
            Console.WriteLine("{0}", br.ReadDouble());

            br.Close();
        }
    }
}

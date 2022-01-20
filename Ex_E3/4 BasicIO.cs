using System;
using System.IO;

namespace BasicIO
{
    class MainApp
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

            Stream outStream = new FileStream("a.dat", FileMode.Create);

            //a.dat 파일 만듬, 없으면 생성
            byte[] wBytes = BitConverter.GetBytes(someValue);

            Console.Write("{0,-13} : ", "Byte array");

            foreach (byte b in wBytes)
                Console.Write("{0:X2} ", b);
            Console.WriteLine();

            outStream.Write(wBytes, 0, wBytes.Length);
            //바이트 배열로 전달해서 씀
            outStream.Close();

            Stream inStream = new FileStream("a.dat", FileMode.Open);
            //새로운 스트림 만듬
            byte[] rbytes = new byte[8];

            int i = 0;
            //Position맨처음에 0 = offset
            while (inStream.Position < inStream.Length)
                rbytes[i++] = (byte)inStream.ReadByte();

            long readValue = BitConverter.ToInt64(rbytes, 0);

            Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
            inStream.Close();
        }
    }
}

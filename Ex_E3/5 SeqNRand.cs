﻿using System;
using System.IO;

namespace SeqNRand
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Stream outStream = new FileStream("a.dat", FileMode.Create);
            Console.WriteLine("Position : {0}", outStream.Position);

            outStream.WriteByte(0x01);
            Console.WriteLine("Position : {0}", outStream.Position);
            //Read/Write하면 Position자동증가

            outStream.WriteByte(0x02);
            Console.WriteLine("Position : {0}", outStream.Position);

            outStream.WriteByte(0x03);
            Console.WriteLine("Position : {0}", outStream.Position);

            outStream.Seek(5, SeekOrigin.Current);
            //-5를 해도 됨
            Console.WriteLine("Position : {0}", outStream.Position);

            outStream.WriteByte(0x04);
            Console.WriteLine("Position : {0}", outStream.Position);

            outStream.Close();
        }
    }
}

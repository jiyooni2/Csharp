using System;
using System.IO;

namespace Touch
{
    class MainApp
    {
        static void OnWrongPathType(string path)
        {
            Console.WriteLine("Type:{0} is wrong type");
            return;
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine(
                    "Usage : Touch.exe <Path> [Type:File/Directory]");
                return;
            }
            //파일의 마지막 변경시간을 바꿔줌


            string path = args[0];
            //string path = "C:\tmp\file.txt"
            string type = "File";
            if (args.Length > 1)
                type = args[1];
            //위에꺼 주석처리

            if (File.Exists(path) || Directory.Exists(path))
            {
                if (type == "File")
                    File.SetLastWriteTime(path, DateTime.Now);
                else if (type == "Directory")
                    Directory.SetLastWriteTime(path, DateTime.Now);
                else
                {
                    OnWrongPathType(path);
                    //error
                    return;
                }
                Console.WriteLine("Updated {0} {1}", path, type);

                return;
            }

            if (type == "File")
                File.Create(path).Close();
            //만들어주기도 함
            else if (type == "Directory")
                Directory.CreateDirectory(path);
            else
            {
                OnWrongPathType(path);
                return;
            }

            Console.WriteLine("Created {0} {1}", path, type);
        }
    }
}

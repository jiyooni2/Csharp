using System;
using System.Linq;
using System.IO;

namespace Dir
{
    class MainApp
    {
        static void Main(string[] args)
        //args사용함 path보내줌
        {
            string directory;
            if (args.Length < 1)
                directory = ".";
            //귀찮으면 directory에
            //
            else
                directory = args[0];

            Console.WriteLine("{0} directory Info", directory);
            Console.WriteLine("- Directories :");
            var directories = (from dir in Directory.GetDirectories(directory)
                                   //디렉토리 밑에있는 서브디렉토리들 string들의 배열로 가져옴
                                   //하나씩 가져와서 dir에 setting
                               let info = new DirectoryInfo(dir)
                               //info가 new DirectoryInfo(dir)가르키게함
                               //DB 쿼리와 같음, 아직 안배움
                               select new
                               {
                                   Name = info.Name,
                                   Attributes = info.Attributes
                               }).ToList();
            //Name과 Attribute만 빼서 list로 만듦

            foreach (var d in directories)
                Console.WriteLine("{0} : {1}", d.Name, d.Attributes);
            //var는 타입 모르겠다, 똑같은 타입으로 setting해라는 뜻
            //compiler가 알아서 맞춰줌

            Console.WriteLine("- Files :");
            var files = (from file in Directory.GetFiles(directory)
                         let info = new FileInfo(file)
                         select new
                         {
                             Name = info.Name,
                             FileSize = info.Length,
                             Attributes = info.Attributes
                         }).ToList();
            foreach (var f in files)
                Console.WriteLine("{0} : {1}, {2}",
                    f.Name, f.FileSize, f.Attributes);
        }
    }
}

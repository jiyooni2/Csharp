using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileTest
{
    class MainApp
    {
        static void Main(string[] args)
        {
            /* Exmaple 1 */
            DirectoryInfo dir = new DirectoryInfo("a");
            //dir이 a디렉토리
            dir.MoveTo("b");
            //a디렉토리가 b디렉토리 밑으로


            /* Example 2 */
            Directory.Move("a", "b");
            //b디렉토리 밑으로 a가

            /* Example 3 */
            string[] files =
                Directory.GetFiles("a");
            //a디렉토리 파일들 string의 array로 return

            foreach (string f in files)
                Console.WriteLine(f);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arrayOfArray = new int[3][];

            //배열 3개, 각 배열의 개수 모른다 정의,채워도됨
            int i, j;

            //그림그려보면 이해빠름, Length가 3이될수밖에없음

            for (i = 0; i < arrayOfArray.Length; i++)
                arrayOfArray[i] = new int[i + 3];
            for (i = 0; i < arrayOfArray.Length; i++)
                for (j = 0; j < arrayOfArray[i].Length; j++)
                    arrayOfArray[i][j] = i * arrayOfArray[i].Length + j;

            for (i = 0; i < arrayOfArray.Length; i++)
            {
                for (j = 0; j < arrayOfArray[i].Length; j++)
                    Console.Write(" " + arrayOfArray[i][j]);
                Console.WriteLine();
            }
        }
    }
}

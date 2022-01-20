using System;

namespace StatementLambda
{
    class MainApp
    {
        delegate string Concatenate(string[] args);

        //메뉴 프로젝트->프로젝트이름 속성->디버그->애플리케이션 인수
        static void Main(string[] args)
        {
            Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                        result += s;

                    return result;
                };
            //익명 람다식 만들어서 delegate에 연결

            Console.WriteLine(concat(args));
            //concat 실행시키면 긴 string하나 return해줌 
        }
    }
}

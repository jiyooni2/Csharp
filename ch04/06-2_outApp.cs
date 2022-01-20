using System;

class OutApp
{
    static void Sum(int x,int y, out int result)
    {
        //x = result + x; 
        //error 발생, result값은 가져온 게 없으니까
        result = x + y;//result에 할당만 가능
    }

    public static void Main()
    {
        int x = 1, y = 2;
        int s;//ref를 사용할 거면, 초기화해야 함
        //out은 초기화 할 필요가 없음

        Sum(x, y, out s);//s의 주소가 result에 저장됨.
        //ref랑 거의 비슷하지만서도...
        //s값을 받지 않고, 밖에있는 어떤 변수에 세팅하겠다.
        //밖의 변수의 값을 실제로 set시킴. ref와 비슷하게 동작
        Console.WriteLine("Sum {0}+{1} = {2}", x, y, s);
    }
}
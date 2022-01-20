using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorApp
{
    class Destructor
    {
        public Destructor()
        {                          // 생성자
            Console.WriteLine("In the constructor ...");
        }
        ~Destructor()//modifier 없음
        {                                // 소멸자
            Console.WriteLine("In the destructor ...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            Destructor d = new Destructor();//객체생성은 됐고, 생성자 호출
            Console.WriteLine("End of Main");
            //main 끝나는 순간 d 사라짐, pointer 없음
            //garbage collector가 grabage object(not pointer)를 가져갈것
            //메모리가 모자를때 GC하거나
            //프로그램이 끝날때 CLR의 GC가 실행
            //garbage object가 될 때 바로 garbage collection 하는 것이 아님
            //여유공간 있으면 천천히 함
            //언제할 지 예측 불가능 알 수 없음
            //객체를 회수할때 소멸자 함수 실행함
        }
    }
}

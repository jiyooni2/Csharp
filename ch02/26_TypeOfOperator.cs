using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace TypeOfOperatorApp
{
    class Apple
    {
        public int nSeeds = 0;
        public void Ripen() { /* ... */ }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Apple);
            //Type 객체, Type을 저장
            string className = t.ToString();
            MemberInfo[] allMembers = t.GetMembers();
            //MemberInfo라는 클래스가 있고
            //각각의 Member를 배열로 만들고
            //전체 필드,메소드 가져와서 저장
            Console.WriteLine("All " + className + " Members:");
            foreach (MemberInfo member in allMembers)
            {
                Console.WriteLine(member.ToString());
            }
        }
    }
}

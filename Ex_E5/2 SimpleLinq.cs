using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
        //자동구현 property
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name="정우성", Height=186},
                new Profile(){Name="김태희", Height=158},
                new Profile(){Name="고현정", Height=172},
                new Profile(){Name="이문세", Height=178},
                new Profile(){Name="하하", Height=171}
            };

            var profiles = from profile in arrProfile
                           where profile.Height < 175
                           orderby profile.Height
                           select new
                           {
                               Name = profile.Name,
                               //무명 datatype인데
                               //여러개 field 선언 시에 ;아니고 ,임
                               InchHeight = profile.Height * 0.393
                           };

            //var이 무명 datatype , 컴파일러가 알아서 지정해줌
            foreach (var profile in profiles)
                Console.WriteLine("{0}, {1}", profile.Name, profile.InchHeight);
        }
    }
}

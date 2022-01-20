using System;
using System.Linq;

namespace GroupBy
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
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

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profiles = g };


            //각각의 listprofile의 elem에 Group.groupkey하고 profile이 있음
            foreach (var Group in listProfile)
            {
                Console.WriteLine("- 175cm 미만? : {0}", Group.GroupKey);

                //False,True인 집합 나오겠지

                foreach (var profile in Group.Profiles)
                {
                    Console.WriteLine("    {0}, {1}", profile.Name, profile.Height);
                }
            }
        }
    }
}

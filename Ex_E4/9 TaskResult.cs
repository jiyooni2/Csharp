using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskResult
{
    class MainApp
    {
        static bool IsPrime(long number)
        {
            if (number < 2)
                return false;

            if (number % 2 == 0 && number != 2)
                return false;

            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            long from = Convert.ToInt64(args[0]);
            long to = Convert.ToInt64(args[1]);
            int taskCount = Convert.ToInt32(args[2]);
            //1,10000,2 task 2개로 1~10000 소수찾아라

            //Func delegate return값 있는 것
            Func<object, List<long>> FindPrimeFunc =
                (objRange) =>
                //object objRange
                {
                    long[] range = (long[])objRange;
                    List<long> found = new List<long>();

                    for (long i = range[0]; i < range[1]; i++)
                    //0~5000
                    {
                        if (IsPrime(i))
                            found.Add(i);
                        //소수이면 found list에 추가
                    }

                    return found;
                };

            Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
            //Long type List인 task 객체 taskCount갯수만큼

            long currentFrom = from;
            long currentTo = to / tasks.Length;
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine("Task[{0}] : {1} ~ {2}",
                    i, currentFrom, currentTo);

                tasks[i] = new Task<List<long>>(FindPrimeFunc,
                    new long[] { currentFrom, currentTo });
                currentFrom = currentTo + 1;

                if (i == tasks.Length - 2)
                    currentTo = to;
                else
                    currentTo = currentTo + (to / tasks.Length);
            }

            Console.WriteLine("Please press enter to start...");
            Console.ReadLine();
            Console.WriteLine("Started...");

            DateTime startTime = DateTime.Now;

            foreach (Task<List<long>> task in tasks)
                task.Start();

            List<long> total = new List<long>();

            foreach (Task<List<long>> task in tasks)
            {
                task.Wait();
                //task끝날때까지 main이 대기
                total.AddRange(task.Result.ToArray());
                //total이 전체
            }
            DateTime endTime = DateTime.Now;

            TimeSpan ellapsed = endTime - startTime;

            Console.WriteLine("Prime number count between {0} and {1} : {2}",
                                                        from, to, total.Count);
            Console.WriteLine("Ellapsed time : {0}", ellapsed);
        }
    }
}

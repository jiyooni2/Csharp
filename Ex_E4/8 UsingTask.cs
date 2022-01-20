using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask
{
    class MainApp
    {


        /*
        
        Task mytask  = Task.Run(
            ()=>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Print");
            }
        );
        바로실행까지 해줌 Asynchronous하게, 병렬실행

        */
        static void Main(string[] args)
        {

            string srcFile = args[0];
            //string srcFile = "C:\tmp\tmpfile.txt";
            Action<object> FileCopyAction = (object state) =>
            {
                String[] paths = (String[])state;
                //String들의 배열로 casting
                //string으로 boxing
                File.Copy(paths[0], paths[1]);
                //copy from 0 to 1

                Console.WriteLine("TaskID:{0}, ThreadID:{1}, {2} was copied to {3}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId,
                    paths[0], paths[1]);
            };

            Task t1 = new Task(
                FileCopyAction,
                new string[] { srcFile, srcFile + ".copy1" });
            //2nd param : object state

            Task t2 = Task.Factory.StartNew(
                FileCopyAction,
                new string[] { srcFile, srcFile + ".copy2" });
            //Asynchronous
            //t2는 바로 실행함
            t1.Start();
            //t1은 이때 실행

            Task t3 = new Task(
                FileCopyAction,
                new string[] { srcFile, srcFile + ".copy3" });

            t3.RunSynchronously();
            //t3는 이때, Synchronous하게 실행
            //main멈추고, t3실행
            //t3가 끝난 상태에서 main실행

            t1.Wait();
            t2.Wait();
            t3.Wait();//이건 의미 없음
        }
    }
}

using System;
using System.Threading;

namespace UsingThreadState
{
    class MainApp
    {
        private static void PrintThreadState(ThreadState state)
        {
            Console.WriteLine("{0,-16} : {1}", state, (int)state);
        }

        static void Main(string[] args)
        {
            //1248..
            PrintThreadState(ThreadState.Running);
            //특정 비트를 1로 세팅해서  

            PrintThreadState(ThreadState.StopRequested);

            PrintThreadState(ThreadState.SuspendRequested);

            PrintThreadState(ThreadState.Background);

            PrintThreadState(ThreadState.Unstarted);

            PrintThreadState(ThreadState.Stopped);

            PrintThreadState(ThreadState.WaitSleepJoin);

            PrintThreadState(ThreadState.Suspended);

            PrintThreadState(ThreadState.AbortRequested);

            PrintThreadState(ThreadState.Aborted);

            PrintThreadState(ThreadState.Aborted | ThreadState.Stopped);
            //이러면 두비트가 1로 세팅
        }
    }
}

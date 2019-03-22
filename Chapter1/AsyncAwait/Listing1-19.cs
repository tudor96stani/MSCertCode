using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Listing1_19
    {
        static void Main(string[] args)
        {
            SleepAsyncB(2000).Wait();
        }

        static Task SleepAsyncA(int ms)
        {
            return Task.Run(() => Thread.Sleep(ms));
        }

        static Task SleepAsyncB(int ms)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(ms, -1);
            return tcs.Task;
        }
    }
}

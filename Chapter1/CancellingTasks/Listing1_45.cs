using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CancellingTasks
{
    class Listing1_45
    {
        static void Main(string[] args)
        {
            Task longRunning = Task.Run(() => Thread.Sleep(10000));

            int idx = Task.WaitAny(new[] { longRunning }, 1000);
            if(idx==-1)
                Console.WriteLine("Task timed out");

            Console.ReadKey();
        }
    }
}

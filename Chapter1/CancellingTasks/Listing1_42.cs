using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CancellingTasks
{
    class Listing1_42
    {
        //static void Main(string[] args)
        //{
        //    CancellationTokenSource cTS = new CancellationTokenSource();
        //    var token = cTS.Token;

        //    Task task = Task.Run(() => {
        //        while (!token.IsCancellationRequested)
        //        {
        //            Console.Write("*");
        //            Thread.Sleep(1000);
        //        }
        //    }, token);

        //    Console.WriteLine("Press enter to stop the task");
        //    Console.ReadLine();
        //    cTS.Cancel();

        //    Console.WriteLine("Press enter to close the app");
        //    Console.ReadLine();
        //}
    }
}

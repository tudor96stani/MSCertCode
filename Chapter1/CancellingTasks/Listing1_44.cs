using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CancellingTasks
{
    class Listing1_44
    {
        //static void Main(string[] args)
        //{
        //    CancellationTokenSource cTS = new CancellationTokenSource();
        //    var token = cTS.Token;

        //    Task task = Task.Run(() =>
        //    {
        //        while (!token.IsCancellationRequested)
        //        {
        //            Console.Write("*");
        //            Thread.Sleep(1000);
        //        }
        //    }, token).ContinueWith((t) =>
        //    {
        //        t.Exception.Handle((e) => true);
        //        Console.WriteLine("Task cancelled");
        //    }, TaskContinuationOptions.OnlyOnCanceled);


        //    Console.WriteLine("Stop task");
        //    Console.ReadLine();
        //    cTS.Cancel();
            

        //    Console.WriteLine("Stop app");
        //    Console.ReadLine();
        //}
    }
}

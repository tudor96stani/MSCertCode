using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CancellingTasks
{
    class Listing1_43
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
        //        token.ThrowIfCancellationRequested();
        //    }, token);

        //    try
        //    {
        //        Console.WriteLine("Stop task");
        //        Console.ReadLine();
        //        cTS.Cancel();
        //        task.Wait();
        //    }
        //    catch(AggregateException e)
        //    {
        //        Console.WriteLine(e.InnerExceptions[0].Message);
        //    }

        //    Console.WriteLine("Stop app");
        //    Console.ReadLine();
        //}
    }
}

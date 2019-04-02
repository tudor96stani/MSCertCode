using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Threading;

namespace ConcurrentCollections.ConcurrentBag
{
    class Listing1_31
    {
        //public static void Main(string[] args)
        //{
        //    ConcurrentBag<int> cb = new ConcurrentBag<int>();
        //    Task.Run(() =>
        //    {
        //        cb.Add(42);
        //        Thread.Sleep(1000);
        //        cb.Add(21);
        //    });
        //    Task.Run(() =>
        //    {
        //        Thread.Sleep(100);
        //        foreach (var i in cb)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    }).Wait();
        //    Console.ReadKey();
        //}
    }
}

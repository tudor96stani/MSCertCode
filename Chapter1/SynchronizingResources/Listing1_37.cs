using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SynchronizingResources
{
    class Listing1_37
    {
        //static void Main(string[] args)
        //{
        //    object _lockA = new object();
        //    object _lockB = new object();
        //    var up = Task.Run(() =>
        //    {
        //        lock (_lockA)
        //        {
        //            Thread.Sleep(100);
        //            lock (_lockB)
        //            {
        //                Console.WriteLine("Locked A and B");
        //            }
        //        }
        //    });
        //    lock (_lockB)
        //    {
        //        Thread.Sleep(100);
        //        lock (_lockA)
        //        {
        //            Console.WriteLine("Locked B and A");
        //        }
        //    }
        //    up.Wait();
        //    Console.ReadKey();
        //}
    }
}

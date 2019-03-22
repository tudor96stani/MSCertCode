using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadClass
{
    class Listing1_6
    {
        static ThreadLocal<int> _field = new ThreadLocal<int>(() => { return Thread.CurrentThread.ManagedThreadId; });
        static void Main(string[] args)
        {
            Console.WriteLine("Listing 1-6");
            new Thread(() => {
                   for(int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0}",i);
                }
            }).Start();

            new Thread(() => {
                for(int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread B: {0}",i);
                }
            }).Start();
            Console.ReadKey();
        }
    }
}

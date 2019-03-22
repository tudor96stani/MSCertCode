using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelStuff
{
    class Listing1_17
    {
        static void Main(string[] args)
        {
            ParallelLoopResult res = Parallel.For(0, 1000, (int i, ParallelLoopState lps) =>
             {
                 if (i == 500)
                 {
                     Console.WriteLine("salcf");
                     lps.Break();
                 }
                 return;
             });
            Console.WriteLine(res.IsCompleted);
            Console.ReadLine();
        }
    }
}

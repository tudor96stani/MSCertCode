using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelLINQ
{
    class Listing1_27
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                        .Where(x => IsEven(x));

                parallelResult.ForAll(x => Console.WriteLine(x));
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("Exception count: " + ex.InnerExceptions.Count);
            }
            Console.ReadKey();
        }

        static bool IsEven(int n)
        {
            if (n % 10 == 0) throw new ArgumentException("n");
            return n % 2 == 0;
        }
    }
}

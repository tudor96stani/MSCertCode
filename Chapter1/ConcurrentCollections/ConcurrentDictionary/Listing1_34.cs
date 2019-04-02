using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentCollections.ConcurrentDictionary
{
    class Listing1_34
    {
        static void Main(string[] args)
        {
            var dict = new ConcurrentDictionary<string, int>();

            if(dict.TryAdd("k1",42))
                Console.WriteLine("Added");

            if(dict.TryUpdate("k1",21,42))
                Console.WriteLine("Updated");

            dict["k1"] = 42;

            int r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            int r2 = dict.GetOrAdd("k1", 3);
            foreach(var kvp in dict)
                Console.WriteLine(kvp.Key + " " + kvp.Value);

            Console.ReadKey();
        }
    }
}

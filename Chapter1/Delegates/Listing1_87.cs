using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Pub
    {
        public event EventHandler OnChange = delegate { };
        public void Raise()
        {
            var exceptions = new List<Exception>();
            foreach (Delegate handler in OnChange.GetInvocationList())
            {
                try
                {
                    handler.DynamicInvoke(this, EventArgs.Empty);
                }
                catch (Exception e)
                {
                    exceptions.Add(e);
                }
            }

            if (exceptions.Any())
            {
                throw new AggregateException(exceptions);
            }
        }
    }
    class Listing1_87
    {
        static void CreateAndRaise()
        {
            Pub p = new Pub();
            p.OnChange += (s, e) => Console.WriteLine("S1 called");
            p.OnChange += (s, e) => throw new Exception();
            p.OnChange += (s, e) => Console.WriteLine("S3 called");

            try
            {
                p.Raise();
            }catch(AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions.Count);
            }
        }
        static void Main(string[] args)
        {
            CreateAndRaise();
            Console.ReadKey();
        }
    }
}

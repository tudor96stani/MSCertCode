using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Listing1_13
    {
        //static void Main(string[] args)
        //{
        //    Task<Int32[]> parent = Task.Run(() =>
        //    {
        //        var res = new Int32[3];
        //        TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);
        //        tf.StartNew(() => res[0] = 0);
        //        tf.StartNew(() => res[1] = 1);
        //        tf.StartNew(() => res[2] = 2);
        //        return res;
        //    });

        //    var finalTask = parent.ContinueWith((parentTask) =>
        //    {
        //        foreach(var i in parentTask.Result)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    });
        //    finalTask.Wait();
        //    Console.ReadKey();
        //}
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Listing1_12
    {
        //static void Main(string[] args)
        //{
        //    Task<Int32[]> parent = Task.Run(() => {
        //        var results = new Int32[3];
        //        new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
        //        new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();
        //        return results;
        //    });

        //    var final = parent.ContinueWith(parentTask =>
        //    {
        //        foreach (int i in parentTask.Result)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    });
        //    final.Wait();
        //    Console.ReadKey();
        //}
    }
}
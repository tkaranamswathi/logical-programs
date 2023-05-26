using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6STOPWATCH
{
    internal class stopwatch
    {
        public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("HI");
            }
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}",
            stopwatch.Elapsed);
        }
    }
}

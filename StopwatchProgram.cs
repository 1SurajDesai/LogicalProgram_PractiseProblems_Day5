using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace LogicalProgramming
{
    public class StopwatchProgram
    {
        public static void CalElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Doing something to spend the time
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1);
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time :  " + stopwatch.Elapsed);

        }
       

        
    }
}

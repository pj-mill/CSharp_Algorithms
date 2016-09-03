using CSharp.Algorithms.Utilities;
using System;
using System.Threading;

namespace CSharp.Algorithms.Numbers
{
    public class FibonacciRun
    {
        public static void Run()
        {
            PrintUtility.PrintTitle("CALCULATE FIBONACCI SEQUENCE FOR 10 NUMBER");

            const int FibonacciCalculations = 10;

            // ManualResetEvent: Notifies one or more waiting threads that an event has occurred.
            // One event for each Fibonacci object
            ManualResetEvent[] doneEvents = new ManualResetEvent[FibonacciCalculations];
            Fibonacci[] fibArray = new Fibonacci[FibonacciCalculations];
            Random r = new Random(); // Used to generate random number for calculating fibonacci sequence

            // Configure and start threads using ThreadPool.
            Console.WriteLine("launching {0} tasks...", FibonacciCalculations);

            for(int i = 0; i < FibonacciCalculations; i++)
            {
                doneEvents[i] = new ManualResetEvent(false);
                Fibonacci fibby = new Fibonacci { Num = r.Next(20, 40), DoneEvent = doneEvents[i] };
                fibArray[i] = fibby;
                ThreadPool.QueueUserWorkItem(fibby.ThreadPoolCallback, i);
            }

            // Wait for all threads in pool to calculate.
            WaitHandle.WaitAll(doneEvents);
            Console.WriteLine("All calculations are complete.");

            // Display the results.
            for (int i = 0; i < FibonacciCalculations; i++)
            {
                Fibonacci fibby = fibArray[i];
                Console.WriteLine("Fibonacci({0}) = {1}", fibby.Num, fibby.FibOfNum);
            }
        }
    }
}

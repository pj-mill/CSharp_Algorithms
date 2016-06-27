using System;
using System.Threading;

namespace CSharp.Algorithms.Numbers
{
    public class Fibonacci
    {
        public int Num { get; set; }
        public int FibOfNum { get; set; }
        public ManualResetEvent DoneEvent { get; set; } // ManualResetEvent: Notifies one or more waiting threads that an event has occurred.

        public void ThreadPoolCallback(object threadidx)
        {
            int idx = (int)threadidx;
            Console.WriteLine($"thread {idx} started...");
            FibOfNum = Calculate(Num);
            Console.WriteLine($"thread {idx} result calculated...");
            DoneEvent.Set();
        }

        // Recursive method that calculates the Nth Fibonacci number.
        public int Calculate(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
}

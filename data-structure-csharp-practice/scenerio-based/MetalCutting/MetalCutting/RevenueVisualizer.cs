using System;
using System.Collections.Generic;
using System.Text;

namespace MetalCutting.MetalCutting
{
    internal class RevenueVisualizer
    {
        public void Compare(int optimized, int nonOptimized)
        {
            Console.WriteLine("\n------ Revenue Comparison ------");
            Console.WriteLine("Without Optimization : " + nonOptimized);
            Console.WriteLine("With Optimization    : " + optimized);
            Console.WriteLine("Profit Difference    : " + (optimized - nonOptimized));
        }
    }
}

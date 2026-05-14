using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture.Furniture
{
    internal class FurnitureOptimizer
    {
        // Scenario A: Max revenue
        // ===============================
        public int MaxRevenue(int[] price, int length)
        {
            int[] dp = new int[length + 1];
            dp[0] = 0;

            for (int i = 1; i <= length; i++)
            {
                int max = -1;

                for (int j = 1; j <= i; j++)
                {
                    int value = price[j] + dp[i - j];
                    if (value > max)
                        max = value;
                }

                dp[i] = max;
            }

            return dp[length];
        }

        // ===============================
        // Scenario B: Waste constraint
        // ===============================
        public int MaxRevenueWithWaste(int[] price, int rodLength, int allowedWaste)
        {
            int usableLength = rodLength - allowedWaste;
            return MaxRevenue(price, usableLength);
        }

        // ===============================
        // Scenario C: Max revenue + min waste
        // ===============================
        public void BestRevenueWithMinWaste(int[] price, int rodLength)
        {
            int bestRevenue = 0;
            int minWaste = rodLength;

            for (int used = rodLength; used >= 0; used--)
            {
                int revenue = MaxRevenue(price, used);
                int waste = rodLength - used;

                if (revenue > bestRevenue ||
                    (revenue == bestRevenue && waste < minWaste))
                {
                    bestRevenue = revenue;
                    minWaste = waste;
                }
            }

            Console.WriteLine("\nBest Revenue : ₹" + bestRevenue);
            Console.WriteLine("Waste       : " + minWaste + " ft");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MetalCutting.MetalCutting
{
    internal class RodCutting
    {
        public int GetMaxRevenue(int[] price, int length)
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

        // Non-optimized strategy (no cut)
        public int NonOptimizedRevenue(int[] price, int length)
        {
            return price[length];
        }
    }
}

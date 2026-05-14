using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture.Furniture
{
    internal class PriceChart
    {
        public int[] Prices;

        public PriceChart()
        {
            Prices = new int[13];

            Prices[0] = 0;
            Prices[1] = 2;
            Prices[2] = 5;
            Prices[3] = 7;
            Prices[4] = 9;
            Prices[5] = 10;
            Prices[6] = 17;
            Prices[7] = 17;
            Prices[8] = 20;
            Prices[9] = 24;
            Prices[10] = 30;
            Prices[11] = 32;
            Prices[12] = 35;
        }

        public void Display()
        {
            Console.WriteLine("\nLength (ft) → Price");
            for (int i = 1; i < Prices.Length; i++)
            {
                Console.WriteLine(i + " → ₹" + Prices[i]);
            }
        }
    }
}

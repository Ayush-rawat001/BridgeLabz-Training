using System;
using System.Collections.Generic;
using System.Text;

namespace MetalCutting.MetalCutting
{
    internal class PriceChart
    {
        public int[] Prices;

        public PriceChart()
        {
            Prices = new int[9];

            Prices[0] = 0;
            Prices[1] = 1;
            Prices[2] = 5;
            Prices[3] = 8;
            Prices[4] = 9;
            Prices[5] = 10;
            Prices[6] = 17;
            Prices[7] = 17;
            Prices[8] = 20;
        }

        public void Display()
        {
            Console.WriteLine("\nLength → Price");
            for (int i = 1; i < Prices.Length; i++)
            {
                Console.WriteLine(i + " → " + Prices[i]);
            }
        }

        public void UpdatePrice(int length, int price)
        {
            Prices[length] = price;
        }
    }
}

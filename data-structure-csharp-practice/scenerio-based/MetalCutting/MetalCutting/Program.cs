using System;
using System.Collections.Generic;
using System.Text;

namespace MetalCutting.MetalCutting
{
    internal class Program
    {
        static void Main()
        {
            RodCutting cutter = new RodCutting();
            PriceChart chart = new PriceChart();
            RevenueVisualizer visualizer = new RevenueVisualizer();

            int rodLength = 8;

            while (true)
            {
                Console.WriteLine("\n===== METAL FACTORY PIPE CUTTING =====");
                Console.WriteLine("1. Scenario A – Best cuts for length 8");
                Console.WriteLine("2. Scenario B – Add custom-length order");
                Console.WriteLine("3. Scenario C – Revenue visualization");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        chart.Display();
                        int best = cutter.GetMaxRevenue(chart.Prices, rodLength);
                        Console.WriteLine("\nMaximum Revenue = " + best);
                        break;

                    case 2:
                        Console.Write("Enter length (1–8): ");
                        int len = int.Parse(Console.ReadLine());

                        Console.Write("Enter new price: ");
                        int price = int.Parse(Console.ReadLine());

                        chart.UpdatePrice(len, price);

                        int updatedRevenue =
                            cutter.GetMaxRevenue(chart.Prices, rodLength);

                        Console.WriteLine("Updated Maximum Revenue = " + updatedRevenue);
                        break;

                    case 3:
                        int optimized =
                            cutter.GetMaxRevenue(chart.Prices, rodLength);

                        int nonOptimized =
                            cutter.NonOptimizedRevenue(chart.Prices, rodLength);

                        visualizer.Compare(optimized, nonOptimized);
                        break;

                    case 4:
                        Console.WriteLine("System terminated.");
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}

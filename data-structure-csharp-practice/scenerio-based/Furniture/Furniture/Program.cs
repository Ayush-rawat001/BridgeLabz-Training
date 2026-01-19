using System;
using System.Collections.Generic;
using System.Text;

namespace Furniture.Furniture
{
    internal class Program
    {
        static void Main()
        {
            FurnitureOptimizer optimizer = new FurnitureOptimizer();
            PriceChart chart = new PriceChart();

            int rodLength = 12;

            while (true)
            {
                Console.WriteLine("\n==== CUSTOM FURNITURE MANUFACTURING ====");
                Console.WriteLine("1. Scenario A  Best cut for 12 ft rod");
                Console.WriteLine("2. Scenario B  Apply waste constraint");
                Console.WriteLine("3. Scenario C  Max revenue with min waste");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        chart.Display();
                        int best =
                            optimizer.MaxRevenue(chart.Prices, rodLength);

                        Console.WriteLine("\nMaximum Revenue = ₹" + best);
                        break;

                    case 2:
                        Console.Write("Allowed waste (ft): ");
                        int waste = int.Parse(Console.ReadLine());

                        int revenue =
                            optimizer.MaxRevenueWithWaste(
                                chart.Prices,
                                rodLength,
                                waste);

                        Console.WriteLine(
                            "Revenue with waste constraint = ₹" + revenue);
                        break;

                    case 3:
                        optimizer.BestRevenueWithMinWaste(
                            chart.Prices,
                            rodLength);
                        break;

                    case 4:
                        Console.WriteLine("Manufacturing closed.");
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}

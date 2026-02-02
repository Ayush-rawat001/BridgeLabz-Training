using System;
using System.Collections.Generic;

public class Program
{
    // Properties
    public string CreatorName { get; set; }
    public double[] WeeklyLikes { get; set; }

    // Static Engagement Board
    public static List<Program> EngagementBoard = new List<Program>();

    // Register creator
    public void RegisterCreator(Program record)
    {
        EngagementBoard.Add(record);
    }

    // Get top post counts
    public Dictionary<string, int> GetTopPostCounts(List<Program> records, double likeThreshold)
    {
        Dictionary<string, int> result = new Dictionary<string, int>();

        foreach (var creator in records)
        {
            int count = 0;
            foreach (double likes in creator.WeeklyLikes)
            {
                if (likes >= likeThreshold)
                    count++;
            }

            if (count > 0)
            {
                result.Add(creator.CreatorName, count);
            }
        }
        return result;
    }

    // Calculate average likes
    public double CalculateAverageLikes()
    {
        double sum = 0;
        int totalWeeks = 0;

        foreach (var creator in EngagementBoard)
        {
            foreach (double likes in creator.WeeklyLikes)
            {
                sum += likes;
                totalWeeks++;
            }
        }

        return totalWeeks == 0 ? 0 : sum / totalWeeks;
    }

    // Main method
    public static void Main()
    {
        Program obj = new Program();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Register Creator");
            Console.WriteLine("2. Show Top Posts");
            Console.WriteLine("3. Calculate Average Likes");
            Console.WriteLine("4. Exit");
            Console.WriteLine("\nEnter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Program creator = new Program();

                    Console.WriteLine("Enter Creator Name:");
                    creator.CreatorName = Console.ReadLine();

                    creator.WeeklyLikes = new double[4];
                    Console.WriteLine("Enter weekly likes (Week 1 to 4):");

                    for (int i = 0; i < 4; i++)
                    {
                        creator.WeeklyLikes[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    obj.RegisterCreator(creator);
                    Console.WriteLine("Creator registered successfully");
                    break;

                case 2:
                    Console.WriteLine("Enter like threshold:");
                    double threshold = Convert.ToDouble(Console.ReadLine());

                    Dictionary<string, int> topPosts =
                        obj.GetTopPostCounts(EngagementBoard, threshold);

                    if (topPosts.Count == 0)
                    {
                        Console.WriteLine("No top-performing posts this week");
                    }
                    else
                    {
                        foreach (var item in topPosts)
                        {
                            Console.WriteLine(item.Key + " - " + item.Value);
                        }
                    }
                    break;

                case 3:
                    double avg = obj.CalculateAverageLikes();
                    Console.WriteLine("Overall average weekly likes: " + avg);
                    break;

                case 4:
                    Console.WriteLine("Logging off - Keep Creating with StreamBuzz!");
                    running = false;
                    break;
            }
        }
    }
}

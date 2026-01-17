using Movie.Movie;
using System;

namespace CinemaTime
{
    class Program
    {
        static void Main()
        {
            MovieManager manager = new MovieManager(20);

            while (true)
            {
                Console.WriteLine("\n===== CINEMA TIME MENU =====");
                Console.WriteLine("1. Add Movie");
                Console.WriteLine("2. Search Movie");
                Console.WriteLine("3. Display All Movies");
                Console.WriteLine("4. Generate Printable Report");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Movie Title: ");
                            string title = Console.ReadLine();

                            Console.Write("Show Time (HH:MM): ");
                            string time = Console.ReadLine();

                            manager.AddMovie(title, time);
                            break;

                        case 2:
                            Console.Write("Search keyword: ");
                            string keyword = Console.ReadLine();

                            manager.SearchMovie(keyword);
                            break;

                        case 3:
                            manager.DisplayAllMovies();
                            break;

                        case 4:
                            manager.GenerateReport();
                            break;

                        case 5:
                            Console.WriteLine("System closed.");
                            return;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
                catch (InvalidTimeFormatException ex)
                {
                    Console.WriteLine("❌ " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected error: " + ex.Message);
                }
            }
        }
    }
}

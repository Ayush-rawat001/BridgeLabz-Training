using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Movie
{
    internal class MovieManager
    {
        private string[] titles;
        private string[] showTimes;
        private int count;

        public MovieManager(int size)
        {
            titles = new string[size];
            showTimes = new string[size];
            count = 0;
        }

        // ---------------- ADD MOVIE ----------------
        public void AddMovie(string title, string time)
        {
            if (!IsValidTime(time))
                throw new InvalidTimeFormatException(
                    "Invalid time format! Use HH:MM (00–23:00–59)");

            if (count >= titles.Length)
            {
                Console.WriteLine("❌ Movie storage full.");
                return;
            }

            titles[count] = title;
            showTimes[count] = time;
            count++;

            Console.WriteLine("✅ Movie added successfully.");
        }

        // ---------------- SEARCH MOVIE ----------------
        public void SearchMovie(string keyword)
        {
            bool found = false;

            try
            {
                for (int i = 0; i < count; i++)
                {
                    if (titles[i].ToLower().Contains(keyword.ToLower()))
                    {
                        Console.WriteLine(
                            "🎬 " + titles[i] + " | Time: " + showTimes[i]);
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine("No matching movie found.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid search index accessed.");
            }
        }

        // ---------------- DISPLAY ALL ----------------
        public void DisplayAllMovies()
        {
            if (count == 0)
            {
                Console.WriteLine("No movies available.");
                return;
            }

            Console.WriteLine("\n🎥 Movie Schedule\n");

            for (int i = 0; i < count; i++)
            {
                string formatted =
                    "Movie: " + titles[i] +
                    " | Showtime: " + showTimes[i];

                Console.WriteLine(formatted);
            }
        }

        // ---------------- PRINT REPORT (ARRAY) ----------------
        public void GenerateReport()
        {
            string[] report = new string[count];

            for (int i = 0; i < count; i++)
            {
                report[i] = titles[i] + " @ " + showTimes[i];
            }

            Console.WriteLine("\n📄 Printable Report\n");

            foreach (string item in report)
            {
                Console.WriteLine(item);
            }
        }

        // ---------------- TIME VALIDATION ----------------
        private bool IsValidTime(string time)
        {
            if (time.Length != 5 || time[2] != ':')
                return false;

            string hh = time.Substring(0, 2);
            string mm = time.Substring(3, 2);

            if (!int.TryParse(hh, out int hour) ||
                !int.TryParse(mm, out int min))
                return false;

            if (hour < 0 || hour > 23 || min < 0 || min > 59)
                return false;

            return true;
        }
    }
}

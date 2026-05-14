using System;

// One movie node
public class MovieBlock
{
    public string heading;
    public string maker;
    public int calendar;
    public double rank;
    public MovieBlock prevLink;
    public MovieBlock nextLink;

    public MovieBlock(string title, string director, int year, double rating)
    {
        heading = title;
        maker = director;
        calendar = year;
        rank = rating;
        prevLink = null;
        nextLink = null;
    }
}

// Doubly linked list handler
public class MovieHub
{
    private MovieBlock first;

    public void PushFront(string title, string director, int year, double rating)
    {
        MovieBlock fresh = new MovieBlock(title, director, year, rating);
        if (first != null)
        {
            fresh.nextLink = first;
            first.prevLink = fresh;
        }
        first = fresh;
        Console.WriteLine("Movie added at start.\n");
    }

    public void PushBack(string title, string director, int year, double rating)
    {
        MovieBlock fresh = new MovieBlock(title, director, year, rating);
        if (first == null)
        {
            first = fresh;
            Console.WriteLine("Movie added as first record.\n");
            return;
        }
        MovieBlock travel = first;
        while (travel.nextLink != null)
            travel = travel.nextLink;

        travel.nextLink = fresh;
        fresh.prevLink = travel;
        Console.WriteLine("Movie added at end.\n");
    }

    public void PushAt(int spot, string title, string director, int year, double rating)
    {
        if (spot == 1)
        {
            PushFront(title, director, year, rating);
            return;
        }

        MovieBlock fresh = new MovieBlock(title, director, year, rating);
        MovieBlock travel = first;

        for (int i = 1; i < spot - 1; i++)
        {
            if (travel == null)
            {
                Console.WriteLine("Invalid position.\n");
                return;
            }
            travel = travel.nextLink;
        }

        fresh.nextLink = travel.nextLink;
        if (travel.nextLink != null)
            travel.nextLink.prevLink = fresh;

        travel.nextLink = fresh;
        fresh.prevLink = travel;
        Console.WriteLine("Movie added at position " + spot + "\n");
    }

    public void PopHeading(string title)
    {
        if (first == null)
        {
            Console.WriteLine("No movies stored.\n");
            return;
        }

        MovieBlock travel = first;

        while (travel != null && travel.heading != title)
            travel = travel.nextLink;

        if (travel == null)
        {
            Console.WriteLine("Movie not found.\n");
            return;
        }

        if (travel == first)
            first = travel.nextLink;

        if (travel.nextLink != null)
            travel.nextLink.prevLink = travel.prevLink;

        if (travel.prevLink != null)
            travel.prevLink.nextLink = travel.nextLink;

        Console.WriteLine("Movie removed.\n");
    }

    public void SeekDirector(string director)
    {
        MovieBlock travel = first;
        bool flag = false;
        while (travel != null)
        {
            if (travel.maker == director)
            {
                Console.WriteLine(travel.heading + " | " + travel.maker + " | " + travel.calendar + " | " + travel.rank);
                flag = true;
            }
            travel = travel.nextLink;
        }
        if (!flag)
            Console.WriteLine("No movie found for this director.\n");
    }

    public void SeekRating(double rating)
    {
        MovieBlock travel = first;
        bool flag = false;
        while (travel != null)
        {
            if (travel.rank == rating)
            {
                Console.WriteLine(travel.heading + " | " + travel.maker + " | " + travel.calendar + " | " + travel.rank);
                flag = true;
            }
            travel = travel.nextLink;
        }
        if (!flag)
            Console.WriteLine("No movie found for this rating.\n");
    }

    public void ViewForward()
    {
        if (first == null)
        {
            Console.WriteLine("No movies to show.\n");
            return;
        }

        Console.WriteLine("\n→ Movie List (Forward)");
        MovieBlock travel = first;
        while (travel != null)
        {
            Console.WriteLine(travel.heading + " | " + travel.maker + " | " + travel.calendar + " | " + travel.rank);
            travel = travel.nextLink;
        }
        Console.WriteLine();
    }

    public void ViewReverse()
    {
        if (first == null)
        {
            Console.WriteLine("No movies to show.\n");
            return;
        }

        MovieBlock travel = first;
        while (travel.nextLink != null)
            travel = travel.nextLink;

        Console.WriteLine("\n← Movie List (Reverse)");
        while (travel != null)
        {
            Console.WriteLine(travel.heading + " | " + travel.maker + " | " + travel.calendar + " | " + travel.rank);
            travel = travel.prevLink;
        }
        Console.WriteLine();
    }
}

// Menu based program starter
public class BootMovieApp
{
    public static void Main()
    {
        MovieHub baseStore = new MovieHub();

        while (true)
        {
            Console.WriteLine("1. Add Movie at Start");
            Console.WriteLine("2. Add Movie at End");
            Console.WriteLine("3. Add Movie at Position");
            Console.WriteLine("4. Remove Movie by Title");
            Console.WriteLine("5. Search Movie by Director");
            Console.WriteLine("6. Search Movie by Rating");
            Console.WriteLine("7. Display Movies Forward");
            Console.WriteLine("8. Display Movies Reverse");
            Console.WriteLine("9. Exit");
            Console.Write("\nEnter option: ");

            int opt = Convert.ToInt32(Console.ReadLine());

            if (opt == 9)
            {
                Console.WriteLine("Closing App...");
                break;
            }
            else if (opt >= 1 && opt <= 3)
            {
                Console.Write("Movie Title: ");
                string title = Console.ReadLine();

                Console.Write("Director Name: ");
                string director = Console.ReadLine();

                Console.Write("Release Year: ");
                int year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Movie Rating: ");
                double rating = Convert.ToDouble(Console.ReadLine());

                if (opt == 1)
                    baseStore.PushFront(title, director, year, rating);
                else if (opt == 2)
                    baseStore.PushBack(title, director, year, rating);
                else if (opt == 3)
                {
                    Console.Write("Enter Position: ");
                    int pos = Convert.ToInt32(Console.ReadLine());
                    baseStore.PushAt(pos, title, director, year, rating);
                }
            }
            else if (opt == 4)
            {
                Console.Write("Enter movie title to remove: ");
                string title = Console.ReadLine();
                baseStore.PopHeading(title);
            }
            else if (opt == 5)
            {
                Console.Write("Enter director name to search: ");
                string director = Console.ReadLine();
                baseStore.SeekDirector(director);
            }
            else if (opt == 6)
            {
                Console.Write("Enter rating to search: ");
                double rating = Convert.ToDouble(Console.ReadLine());
                baseStore.SeekRating(rating);
            }
            else if (opt == 7)
            {
                baseStore.ViewForward();
            }
            else if (opt == 8)
            {
                baseStore.ViewReverse();
            }
            else
            {
                Console.WriteLine("Wrong choice, try again.\n");
            }
        }
    }
}

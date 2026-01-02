using System;

class Library
{
    public string[,] bookData = new string[50, 3];
    public int total = 0;

    public void LoadBooks(string[,] sample)
    {
        for (int i = 0; i < 30; i++)
        {
            bookData[i, 0] = sample[i, 0];
            bookData[i, 1] = sample[i, 1];
            bookData[i, 2] = sample[i, 2];
            total++;
        }
    }
//show all books
    public void Show()
    {
        Console.WriteLine("\n---- Book List ----");
        for (int i = 0; i < total; i++)
        {
            Console.WriteLine("[" + (i+1) + "] " + bookData[i,0] + " - " + bookData[i,1] + " - " + bookData[i,2]);
        }
    }
//find a book
    public void Find()
    {
        Console.Write("\nType book name: ");
        string s = Console.ReadLine() ?? "";
        s = s.ToLower();

        for (int i = 0; i < total; i++)
        {
            string b = bookData[i, 0].ToLower();
            if (b.IndexOf(s) >= 0)
            {
                Console.WriteLine("Match at slot " + (i+1) + ": " + bookData[i,0]);
                Console.WriteLine("Writer: " + bookData[i,1]);
                Console.WriteLine("State: " + bookData[i,2]);
                return;
            }
        }

        Console.WriteLine("Not found");
    }
   // issue book
    public void Issue()
    {
        Console.Write("\nEnter slot: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (bookData[x-1,2] == "Available")
        {
            bookData[x-1,2] = "Borrowed";
            Console.WriteLine("Done");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}

class Start
{
    public static void Main()
    {    // books list
        string[,] b = new string[30, 3] {
            { "The Alchemist", "Paulo Coelho", "Available" },
            { "1984", "George Orwell", "Borrowed" },
            { "The Great Gatsby", "F. Scott Fitzgerald", "Available" },
            { "To Kill a Mockingbird", "Harper Lee", "Available" },
            { "The Hobbit", "J.R.R. Tolkien", "Borrowed" },
            { "Mathura: A District Memoir", "F.S. Growse", "Available" },
            { "The Gita", "Vyasa", "Available" },
            { "War and Peace", "Leo Tolstoy", "Borrowed" },
            { "Ulysses", "James Joyce", "Available" },
            { "The Catcher in the Rye", "J.D. Salinger", "Available" },
            { "Pride and Prejudice", "Jane Austen", "Borrowed" },
            { "Brave New World", "Aldous Huxley", "Available" },
            { "The Little Prince", "Antoine de Saint-Exupéry", "Available" },
            { "The Odyssey", "Homer", "Borrowed" },
            { "Crime and Punishment", "Fyodor Dostoevsky", "Available" },
            { "The Divine Comedy", "Dante Alighieri", "Available" },
            { "Moby Dick", "Herman Melville", "Borrowed" },
            { "Gulliver's Travels", "Jonathan Swift", "Available" },
            { "The Iliad", "Homer", "Available" },
            { "One Hundred Years of Solitude", "Gabriel García Márquez", "Borrowed" },
            { "The Brothers Karamazov", "Fyodor Dostoevsky", "Available" },
            { "The Stranger", "Albert Camus", "Available" },
            { "Madam Bovary", "Gustave Flaubert", "Borrowed" },
            { "Old Man and the Sea", "Ernest Hemingway", "Available" },
            { "The Trial", "Franz Kafka", "Available" },
            { "The Castle", "Franz Kafka", "Borrowed" },
            { "Waiting for Godot", "Samuel Beckett", "Available" },
            { "The Metamorphosis", "Franz Kafka", "Available" },
            { "Faust", "Johann Wolfgang von Goethe", "Borrowed" },
            { "A Tale of Two Cities", "Charles Dickens", "Available" }
        };
            //object creation
        Library a = new Library();
        a.LoadBooks(b);
        
        //infinite loop
        while (true)
        {
            Console.WriteLine("\n1.Show 2.Search 3.Checkout 4.Stop");
            int c = Convert.ToInt32(Console.ReadLine());

            if (c == 1)
                a.Show();
            else if (c == 2)
                a.Find();
            else if (c == 3)
                a.Issue();
            else if (c == 4)
                break;
            else
                Console.WriteLine("Wrong");
        }
    }
}

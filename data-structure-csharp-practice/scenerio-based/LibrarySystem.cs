using System;

namespace LibrarySystem
{
    // ---------------- BOOK NODE ----------------
    class BookNode
    {
        public string Title;
        public string Author;
        public BookNode Next;

        public BookNode(string title, string author)
        {
            Title = title;
            Author = author;
            Next = null;
        }
    }

    // ---------------- LINKED LIST ----------------
    class BookLinkedList
    {
        private BookNode head;

        // Insert book
        public bool AddBook(string title, string author)
        {
            if (IsDuplicate(title, author))
                return false;

            BookNode newNode = new BookNode(title, author);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                BookNode temp = head;
                while (temp.Next != null)
                    temp = temp.Next;

                temp.Next = newNode;
            }

            return true;
        }

        // Check duplicate
        private bool IsDuplicate(string title, string author)
        {
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.Title == title && temp.Author == author)
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        // Delete book
        public bool RemoveBook(string title)
        {
            if (head == null)
                return false;

            if (head.Title == title)
            {
                head = head.Next;
                return true;
            }

            BookNode curr = head;
            BookNode prev = null;

            while (curr != null)
            {
                if (curr.Title == title)
                {
                    prev.Next = curr.Next;
                    return true;
                }

                prev = curr;
                curr = curr.Next;
            }

            return false;
        }

        // Display books
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("   No books available.");
                return;
            }

            BookNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"   - {temp.Title} by {temp.Author}");
                temp = temp.Next;
            }
        }
    }

    // ---------------- GENRE SHELF ----------------
    class GenreShelf
    {
        public string GenreName;
        public BookLinkedList Books;

        public GenreShelf(string genre)
        {
            GenreName = genre;
            Books = new BookLinkedList();
        }
    }

    // ---------------- LIBRARY SYSTEM ----------------
    class LibrarySystem
    {
        private GenreShelf[] genres;
        private int genreCount;

        public LibrarySystem(int size)
        {
            genres = new GenreShelf[size];
            genreCount = 0;
        }

        // Find genre index
        private int FindGenre(string genre)
        {
            for (int i = 0; i < genreCount; i++)
            {
                if (genres[i].GenreName == genre)
                    return i;
            }
            return -1;
        }

        // Add book
        public void AddBook(string genre, string title, string author)
        {
            int index = FindGenre(genre);

            if (index == -1)
            {
                genres[genreCount] = new GenreShelf(genre);
                index = genreCount;
                genreCount++;
            }

            bool added = genres[index].Books.AddBook(title, author);

            if (added)
                Console.WriteLine("✅ Book added successfully.");
            else
                Console.WriteLine("❌ Duplicate book not allowed.");
        }

        // Borrow book
        public void BorrowBook(string genre, string title)
        {
            int index = FindGenre(genre);

            if (index == -1)
            {
                Console.WriteLine("❌ Genre not found.");
                return;
            }

            bool removed = genres[index].Books.RemoveBook(title);

            if (removed)
                Console.WriteLine("📕 Book borrowed successfully.");
            else
                Console.WriteLine("❌ Book not found.");
        }

        // Display catalog
        public void DisplayLibrary()
        {
            Console.WriteLine("\n📘 LIBRARY CATALOG\n");

            if (genreCount == 0)
            {
                Console.WriteLine("Library empty.");
                return;
            }

            for (int i = 0; i < genreCount; i++)
            {
                Console.WriteLine("Genre: " + genres[i].GenreName);
                genres[i].Books.Display();
                Console.WriteLine();
            }
        }
    }

    // ---------------- MAIN ----------------
    class Program
    {
        static void Main()
        {
            LibrarySystem library = new LibrarySystem(20);

            while (true)
            {
                Console.WriteLine("\n===== LIBRARY MENU =====");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Borrow Book");
                Console.WriteLine("3. Display Library");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Author: ");
                        string author = Console.ReadLine();

                        library.AddBook(genre, title, author);
                        break;

                    case 2:
                        Console.Write("Genre: ");
                        string g = Console.ReadLine();

                        Console.Write("Book Title: ");
                        string t = Console.ReadLine();

                        library.BorrowBook(g, t);
                        break;

                    case 3:
                        library.DisplayLibrary();
                        break;

                    case 4:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}

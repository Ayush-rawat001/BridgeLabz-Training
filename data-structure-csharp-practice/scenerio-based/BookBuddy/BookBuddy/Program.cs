using System;

namespace BookBuddy
{
    class Program
    {
        static void Main()
        {
            BookManager manager = new BookManager();
            int choice;

            do
            {
                Console.WriteLine("\n📚 BOOKBUDDY DIGITAL BOOKSHELF");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Sort Books Alphabetically");
                Console.WriteLine("3. Search by Author");
                Console.WriteLine("4. Display All Books");
                Console.WriteLine("5. Export Books to Array");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine();

                            Console.Write("Enter Author: ");
                            string author = Console.ReadLine();

                            manager.AddBook(title, author);
                            break;

                        case 2:
                            manager.SortBooksAlphabetically();
                            break;

                        case 3:
                            Console.Write("Enter author name: ");
                            string search = Console.ReadLine();
                            manager.SearchByAuthor(search);
                            break;

                        case 4:
                            manager.DisplayAllBooks();
                            break;

                        case 5:
                            manager.ExportToArray();
                            break;

                        case 6:
                            Console.WriteLine("👋 Exiting BookBuddy...");
                            break;

                        default:
                            Console.WriteLine("❌ Invalid choice.");
                            break;
                    }
                }
                catch (InvalidBookFormatException ex)
                {
                    Console.WriteLine("❌ " + ex.Message);
                }
            }
            while (choice != 6);
        }
    }
}

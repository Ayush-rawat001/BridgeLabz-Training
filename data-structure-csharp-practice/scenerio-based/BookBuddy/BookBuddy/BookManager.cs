using System;
using System.Collections;

namespace BookBuddy
{
    class BookManager
    {
        private ArrayList books = new ArrayList();

        // ---------------- ADD BOOK ----------------
        public void AddBook(string title, string author)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
                throw new InvalidBookFormatException(
                    "Book must be in 'Title - Author' format.");

            Book book = new Book(title, author);
            books.Add(book);

            Console.WriteLine("✅ Book added successfully.");
        }

        // ---------------- SORT BOOKS ----------------
        public void SortBooksAlphabetically()
        {
            try
            {
                if (books.Count == 0)
                    throw new Exception("Bookshelf is empty.");

                for (int i = 0; i < books.Count - 1; i++)
                {
                    for (int j = i + 1; j < books.Count; j++)
                    {
                        Book b1 = (Book)books[i];
                        Book b2 = (Book)books[j];

                        if (string.Compare(b1.Title, b2.Title) > 0)
                        {
                            books[i] = b2;
                            books[j] = b1;
                        }
                    }
                }

                Console.WriteLine("✅ Books sorted alphabetically.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ " + ex.Message);
            }
        }

        // ---------------- SEARCH BY AUTHOR ----------------
        public void SearchByAuthor(string author)
        {
            try
            {
                if (books.Count == 0)
                    throw new Exception("Bookshelf is empty.");

                bool found = false;

                foreach (Book book in books)
                {
                    if (book.Author.ToLower().Contains(author.ToLower()))
                    {
                        Console.WriteLine(book);
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine("❌ No books found for this author.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ " + ex.Message);
            }
        }

        // ---------------- DISPLAY ALL ----------------
        public void DisplayAllBooks()
        {
            try
            {
                if (books.Count == 0)
                    throw new Exception("Bookshelf is empty.");

                foreach (Book book in books)
                {
                    Console.WriteLine(book);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ " + ex.Message);
            }
        }

        // ---------------- EXPORT ARRAY ----------------
        public void ExportToArray()
        {
            try
            {
                if (books.Count == 0)
                    throw new Exception("No books to export.");

                Book[] bookArray = (Book[])books.ToArray(typeof(Book));

                Console.WriteLine("\n📄 Exported Book Report:");
                foreach (Book b in bookArray)
                {
                    Console.WriteLine(b);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ " + ex.Message);
            }
        }
    }
}

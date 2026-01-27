using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace LibManagementSystem.LibManagementSystem
{
    class BookUtility
    {
        private Book[] books = new Book[50];
        private int count = 0;

        
        public void AddBook()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            books[count] = new Book(title, author, "Available");
            count++;

            Console.WriteLine("Book added successfully!");
        }

        
        public void Search(string title)
        {
            if (count == 0)
            {
                Console.WriteLine("No books in library");
                return;
            }

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (books[i].GetTitle().ToLower().Contains(title.ToLower()))
                {
                    Console.WriteLine(
                        "Title: " + books[i].GetTitle() +" | Author: " + books[i].GetAuthor() +" | Status: " + books[i].GetStatus()
                    );
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found");
            }
        }

      
        public void Issue(string title)
        {
            for (int i = 0; i < count; i++)
            {
                if (books[i].GetTitle().ToLower().Contains(title.ToLower()))
                {
                    if (books[i].GetStatus() == "Available")
                    {
                        books[i].SetStatus("Issued");
                        Console.WriteLine("Book issued successfully");
                    }
                    else
                    {
                        Console.WriteLine("Book already issued");
                    }
                    return;
                }
            }

            Console.WriteLine("Book not found");
        }

        
        public void Display()
        {
            if (count == 0)
            {
                Console.WriteLine("No books available");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(
                        "Title: " + books[i].GetTitle() + " | Author: " + books[i].GetAuthor() + " | Status: " + books[i].GetStatus()
                    );
            }
        }
    }
}

using System;

class LibraryBook
{
    private string book;
    private string writer;
    private double price;
    private bool available;

    

    public LibraryBook(string book, string writer, double price, bool available)
    {
        this.book = book;
        this.writer = writer;
        this.price = price;
        this.available = available;
    }

    private void ChangeStatus()
    {
        available = false;
    }

    public void BorrowBook()
    {
        if (available)
        {
            ChangeStatus();
            Console.WriteLine("\n borrowed successfully!\n");
        }
        else
        {
            Console.WriteLine("\nbook not in stock.\n");
        }
    }

    public void PrintBook()
    {
        Console.WriteLine($"\n[Library Book]\nTitle: {book}\nAuthor: {writer}\nPrice: ₹{price}\nStatus: {(available ? "In Stock" : "Issued")}\n");
    }

    public static void Main()
    {
        LibraryBook lb = new LibraryBook("Programmer", "", 500, true);
        lb.PrintBook();//not issued
        lb.BorrowBook();// book in stock
        lb.PrintBook();// issued
        lb.BorrowBook();// book not in stock
    }
}

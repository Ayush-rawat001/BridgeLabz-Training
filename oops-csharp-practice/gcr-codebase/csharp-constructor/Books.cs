using System;

class BookInfo
{
    private string title;
    private string author;
    private double price;

    public BookInfo()
    {
        title = "Unknown";
        author = "Unknown";
        price = 0;
    }

    public BookInfo(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.price = price;
    }

    public void PrintBook()
    {
        Console.WriteLine($"\n[Book Record]\nName: {title}\nWriter: {author}\nCost: ₹{price}\n");
    }

    public static void Main()
    {
        BookInfo b = new BookInfo();
        b.PrintBook();

        BookInfo b2 = new BookInfo("Clean Code", "Robert Martin", 650);
        b2.PrintBook();
    }
}

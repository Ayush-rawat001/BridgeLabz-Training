using System;

class program
{
    string bookHeading;
    string creator;
    double costValue;

    public  program(string heading, string writer, double cost)
    {
        bookHeading = heading;
        creator = writer;
        costValue = cost;
    }

    public void print()
    {
        Console.WriteLine("\n--- Book Summary ---");
        Console.WriteLine("Title  : " + bookHeading);
        Console.WriteLine("Author : " + creator);
        Console.WriteLine("Price  : ₹" + costValue);
        Console.WriteLine("-------------------");
    }
}

class Books
{
    static void Main()
    {
        Console.WriteLine("Enter book name:");
        string title = Console.ReadLine() ;

        Console.WriteLine("Enter writer name:");
        string author = Console.ReadLine() ;

        Console.WriteLine("Enter book price:");
        double price = Convert.ToDouble(Console.ReadLine());

        program b1 = new program(title, author, price);
        b1.print();
    }
}

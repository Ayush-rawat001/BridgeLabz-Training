using System;

class Book
{
    // static shared variable
    public static string libraryName = "Global Knowledge Center";

   
    public readonly string isbn;

   
    public string title;
    public string author;

    // constructor using this keyword
    public Book(string title, string author, string isbn)
    {
        this.title = title;
        this.author = author;
        this.isbn = isbn;
    }

    // static method to display library name
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library: " + libraryName);
    }

    // method to print book details
    public void ShowBookInfo()
    {
        Console.WriteLine("\n--- Book Record ---");
        Console.WriteLine("Name  : " + title);
        Console.WriteLine("Writer: " + author);
        Console.WriteLine("ISBN  : " + isbn);
        Console.WriteLine("------------------");
    }
}

class RunSystem
{
    public static void Main()
    {
        Console.WriteLine("Enter Book Title:");
        string bTitle = Console.ReadLine();

        Console.WriteLine("Enter Book Author:");
        string bAuthor = Console.ReadLine();

        Console.WriteLine("Enter ISBN Code:");
        string bIsbn = Console.ReadLine();

        Book bookObj = new Book(bTitle, bAuthor, bIsbn);

        // static method call
        Book.DisplayLibraryName();

        Console.WriteLine("\nVerifying instance using 'is' operator...");

        // is operator check
        if (bookObj is Book)
        {
            Console.WriteLine("Verified: Object belongs to Book class.");
            bookObj.ShowBookInfo();
        }
        else
        {
            Console.WriteLine("Not a valid Book object.");
        }
    }
}

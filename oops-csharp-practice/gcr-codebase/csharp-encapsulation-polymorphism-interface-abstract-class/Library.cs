using System;

public interface IReservable
{
    void ReserveItem();
    bool CheckAvailability();
}

public abstract class LibraryItem : IReservable
{
    private string uid;
    private string heading;
    private string creator;
    private string secretBorrower; // sensitive data

    public string Uid { get { return uid; } }
    public string Heading { get { return heading; } }
    public string Creator { get { return creator; } }

    // Encapsulated setters
    public void SetUid(string id) { uid = id; }
    public void SetHeading(string name) { heading = name; }
    public void SetCreator(string writer) { creator = writer; }

    // Encapsulation for borrower data
    public void StoreBorrowerData(string person)
    {
        secretBorrower = person;
    }

    public string AccessBorrowerData()
    {
        return "Borrower Data Protected"; // never reveal real data
    }

    public void GetItemDetails()
    {
        Console.WriteLine("\n--- Item Card ---");
        Console.WriteLine("Item ID   → " + uid);
        Console.WriteLine("Name     → " + heading);
        Console.WriteLine("By       → " + creator);
        Console.WriteLine("Status   → " + AccessBorrowerData());
    }

    public abstract int GetLoanDuration();

    // Interface methods
    private bool isFree = true;

    public void ReserveItem()
    {
        if (isFree)
        {
            isFree = false;
            Console.WriteLine("Item Reserved Successfully!");
        }
        else Console.WriteLine("Item not available for reservation!");
    }

    public bool CheckAvailability()
    {
        return isFree;
    }
}

public class PaperBook : LibraryItem
{
    public override int GetLoanDuration() => 14; // 14 days
}

public class WeeklyMagazine : LibraryItem
{
    public override int GetLoanDuration() => 7; // 7 days
}

public class DigitalDVD : LibraryItem
{
    public override int GetLoanDuration() => 3; // 3 days
}

public class LibraryMenuConsole
{
    private static LibraryItem[] itemShelf = new LibraryItem[10];
    private static int filled = 0;

    public static void AddItem()
    {
        if (filled >= itemShelf.Length)
        {
            Console.WriteLine("Shelf is full!\n");
            return;
        }

        Console.WriteLine("\nSelect Item Type:");
        Console.WriteLine("1 → Book");
        Console.WriteLine("2 → Magazine");
        Console.WriteLine("3 → DVD");
        Console.Write("Choose: ");

        int pick = Convert.ToInt32(Console.ReadLine());
        LibraryItem item;

        if (pick == 1) item = new PaperBook();
        else if (pick == 2) item = new WeeklyMagazine();
        else if (pick == 3) item = new DigitalDVD();
        else { Console.WriteLine("Invalid choice!\n"); return; }

        Console.Write("Enter Item ID: ");
        item.SetUid(Console.ReadLine());

        Console.Write("Enter Title: ");
        item.SetHeading(Console.ReadLine());

        Console.Write("Enter Author Name: ");
        item.SetCreator(Console.ReadLine());

        Console.Write("Enter Borrower Name (stored securely): ");
        item.StoreBorrowerData(Console.ReadLine());

        itemShelf[filled++] = item;
        Console.WriteLine("Item Added!\n");
    }

    public static void ViewItems()
    {
        if (filled == 0) { Console.WriteLine("No items stored!\n"); return; }

        Console.WriteLine("\n=== Library Items ===");
        for (int i = 0; i < filled; i++)
        {
            Console.WriteLine($"{i + 1}. {itemShelf[i].Heading} (ID:{itemShelf[i].Uid})");
        }
        Console.WriteLine();
    }

    public static void ReserveFlow()
    {
        Console.Write("Enter Item ID to Reserve: ");
        string find = Console.ReadLine();

        for (int i = 0; i < filled; i++)
        {
            if (itemShelf[i].Uid == find)
            {
                itemShelf[i].ReserveItem();
                return;
            }
        }
        Console.WriteLine("Item not found!\n");
    }

    public static void AvailabilityFlow()
    {
        Console.Write("Enter Item ID to Check: ");
        string find = Console.ReadLine();

        for (int i = 0; i < filled; i++)
        {
            if (itemShelf[i].Uid == find)
            {
                Console.WriteLine(itemShelf[i].CheckAvailability() ? "Item is Available\n" : "Item is Not Available\n");
                return;
            }
        }
        Console.WriteLine("Item not found!\n");
    }

    public static void LoanDurationFlow()
    {
        if (filled == 0) { Console.WriteLine("No items!\n"); return; }

        Console.WriteLine("\n=== Loan Duration Report ===");
        for (int i = 0; i < filled; i++)
        {
            Console.WriteLine(itemShelf[i].Heading + " → Loan Days: " + itemShelf[i].GetLoanDuration());
        }
        Console.WriteLine();
    }

    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("==== Library Menu ====");
            Console.WriteLine("1 → Add Item");
            Console.WriteLine("2 → View Items");
            Console.WriteLine("3 → Reserve Item");
            Console.WriteLine("4 → Check Availability");
            Console.WriteLine("5 → Show Loan Duration");
            Console.WriteLine("6 → Exit");
            Console.Write("Select: ");

            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1) AddItem();
            else if (option == 2) ViewItems();
            else if (option == 3) ReserveFlow();
            else if (option == 4) AvailabilityFlow();
            else if (option == 5) LoanDurationFlow();
            else if (option == 6) break;
            else Console.WriteLine("Invalid option!\n");
        }

        Console.WriteLine("\nLibrary Console Closed.");
    }
}

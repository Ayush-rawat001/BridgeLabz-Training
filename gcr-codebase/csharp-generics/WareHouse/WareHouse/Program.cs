using System;

class Program
{
    static Storage<Electronics> electronicsStorage = new Storage<Electronics>();
    static Storage<Groceries> groceryStorage = new Storage<Groceries>();
    static Storage<Furniture> furnitureStorage = new Storage<Furniture>();

    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== SMART WAREHOUSE SYSTEM =====");
            Console.WriteLine("1. Add Electronics");
            Console.WriteLine("2. Add Grocery");
            Console.WriteLine("3. Add Furniture");
            Console.WriteLine("4. View Electronics");
            Console.WriteLine("5. View Groceries");
            Console.WriteLine("6. View Furniture");
            Console.WriteLine("0. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddElectronics();
                    break;

                case 2:
                    AddGrocery();
                    break;

                case 3:
                    AddFurniture();
                    break;

                case 4:
                    electronicsStorage.DisplayItems();
                    break;

                case 5:
                    groceryStorage.DisplayItems();
                    break;

                case 6:
                    furnitureStorage.DisplayItems();
                    break;

                case 0:
                    Console.WriteLine("Exiting system...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 0);
    }

    static void AddElectronics()
    {
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Brand: ");
        string brand = Console.ReadLine();

        electronicsStorage.AddItem(
            new Electronics(id, name, brand)
        );
    }

    static void AddGrocery()
    {
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Expiry Date: ");
        string expiry = Console.ReadLine();

        groceryStorage.AddItem(
            new Groceries(id, name, expiry)
        );
    }

    static void AddFurniture()
    {
        Console.Write("Enter ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Material: ");
        string material = Console.ReadLine();

        furnitureStorage.AddItem(
            new Furniture(id, name, material)
        );
    }
}

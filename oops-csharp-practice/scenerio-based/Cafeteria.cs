using System;

class CafeteriaApp
{
    static string[] menuItems = new string[10]
    {
        "Veg Sandwich","Burger","Noodles","Cold Coffee","Tea",
        "French Fries","Pasta","Samosa","Coke","Idli"
    };

    static double[] itemPrices = new double[10]
    {
        400, 600, 500, 300, 150,
        450, 550, 120, 200, 250
    };

    static void Main()
    {
        Console.WriteLine("\n---Welcome to ek baar khaoge fir nhi aaoge---\n");
        DisplayMenu();

        double totalBill = 0;

        while (true)
        {
            Console.Write("\nEnter item number to order (or -1 to finish): ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == -1)
                break;

            string item = GetItemByIndex(choice-1);
            double price = GetPriceByIndex(choice-1);

            if (item != null)
            {
                Console.Write("Enter quantity: ");
                int qty = int.Parse(Console.ReadLine());

                double cost = price * qty;
                totalBill += cost;

                Console.WriteLine($"Added: {item} × {qty}  →  ₹{cost}");
            }
            else
            {
                Console.WriteLine("Invalid item number, skipped!");
            }
        }

        Console.WriteLine("\n------ Final Bill ------");
        Console.WriteLine("Total Amount: ₹" + totalBill);
        Console.WriteLine("-----------------------\n");
        Console.WriteLine("Thanks for ordering!\n");
    }

    public static void DisplayMenu()
    {
        Console.WriteLine("Today's Menu:\n----------------------------");
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine(i+1 + ". " + menuItems[i] + "  →  ₹" + itemPrices[i]);
        }
        Console.WriteLine("----------------------------");
    }

    public static string GetItemByIndex(int i)
    {
        
            return menuItems[i];
        
    }

    public static double GetPriceByIndex(int i)
    {
       
            return itemPrices[i];
        
    }
}

using System;

class GoodsItem
{
    // instance variables
    public string item;
    public double cost;

    // class variable 
    public static int count = 0;

    public GoodsItem(string item, double cost)
    {
        this.item = item;
        this.cost = cost;
        count++;
    }

    // instance method
    public void PrintItem()
    {
        Console.WriteLine("\nItem Name : " + item);
        Console.WriteLine("Item Cost : ₹" + cost);
    }

    // class method
    public static void PrintTotal()
    {
        Console.WriteLine("\nTotal Items Created: " + count);
    }
}

class StartApp
{
    public static void Main()
    {
        Console.WriteLine("product name:");
        string n = Console.ReadLine() ?? "";

        Console.WriteLine(" price:");
        double p = Convert.ToDouble(Console.ReadLine());

        GoodsItem g = new GoodsItem(n, p);
        g.PrintItem();
        GoodsItem.PrintTotal();
    }
}

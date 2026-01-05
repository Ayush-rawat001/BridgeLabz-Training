using System;

class Product
{
    // static variable shared
    public static double discountPercent = 10.0;

    // readonly unique product ID
    public readonly int productID;

    // instance variables
    public string productName;
    public int quantity;
    public double price;

    // constructor using this
    public Product(string productName, double price, int quantity, int productID)
    {
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
        this.productID = productID;
    }

    // static method to update discount
    public static void UpdateDiscount(double newDiscount)
    {
        if (newDiscount >= 0 && newDiscount <= 90)
            discountPercent = newDiscount;
    }

    // method to process product bill
    public void ProcessCart()
    {
        double total = price * quantity;
        double finalAmount = total - (total * discountPercent / 100);

        Console.WriteLine("\n--- Cart Item ---");
        Console.WriteLine("Item       : " + productName);
        Console.WriteLine("Price      : " + price);
        Console.WriteLine("Quantity   : " + quantity);
        Console.WriteLine("Product ID : " + productID);
        Console.WriteLine("Discount   : " + discountPercent + "%");
        Console.WriteLine("Total Cost : " + finalAmount);
        Console.WriteLine("----------------");
    }
}

class CartApp
{
    public static void Main()
    {
        Console.WriteLine("Enter Product Name:");
        string pName = Console.ReadLine();

        Console.WriteLine("Enter Product Price:");
        double pPrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Quantity:");
        int pQty = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Product ID ");
        int pID = Convert.ToInt32(Console.ReadLine());

        Product item = new Product(pName, pPrice, pQty, pID);

       

        // is operator check
        if (item is Product)
        {
            Console.WriteLine("Validation Success: It is a Product object.");
            item.ProcessCart();
        }

        Console.WriteLine("\nUpdate discount for all products? Enter new discount:");
        double newDis = Convert.ToDouble(Console.ReadLine());

        Product.UpdateDiscount(newDis);

        Console.WriteLine("\nRe-printing after discount update...");

        // Validate again before printing
        if (item is Product)
            item.ProcessCart();
    }
}

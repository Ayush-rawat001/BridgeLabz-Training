using System;

public class Groceries : WarehouseItem
{
    public string ExpiryDate { get; set; }

    public Groceries(int id, string name, string expiry)
        : base(id, name)
    {
        ExpiryDate = expiry;
    }

    public override void Display()
    {
        Console.WriteLine($"[Grocery] ID: {Id}, Name: {Name}, Expiry: {ExpiryDate}");
    }
}

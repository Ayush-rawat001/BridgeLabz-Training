using System;

public class Electronics : WarehouseItem
{
    public string Brand { get; set; }

    public Electronics(int id, string name, string brand)
        : base(id, name)
    {
        Brand = brand;
    }

    public override void Display()
    {
        Console.WriteLine($"[Electronics] ID: {Id}, Name: {Name}, Brand: {Brand}");
    }
}

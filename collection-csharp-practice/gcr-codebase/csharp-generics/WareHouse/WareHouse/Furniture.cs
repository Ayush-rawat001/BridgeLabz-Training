using System;

public class Furniture : WarehouseItem
{
    public string Material { get; set; }

    public Furniture(int id, string name, string material)
        : base(id, name)
    {
        Material = material;
    }

    public override void Display()
    {
        Console.WriteLine($"[Furniture] ID: {Id}, Name: {Name}, Material: {Material}");
    }
}

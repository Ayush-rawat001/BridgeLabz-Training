using System;
using System.Collections.Generic;

public class Storage<T> where T : WarehouseItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
        Console.WriteLine("Item added successfully.");
    }

    public void DisplayItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("No items available.");
            return;
        }

        foreach (T item in items)
            item.Display();
    }
}

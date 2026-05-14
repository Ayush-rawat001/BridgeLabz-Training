using System;

// Tax interface
public interface ITaxable
{
    double CalculateTax();
    string GetTaxReport();
}

// Abstract Product class
public abstract class ProductItem
{
    private int code;
    private string label;
    private double cost;

    // Encapsulated access using properties
    public int Code
    {
        get { return code; }
    }

    public string Label
    {
        get { return label; }
    }

    public double Cost
    {
        get { return cost; }
    }

    // Setter methods for protected updates
    public void SetCode(int newCode)
    {
        code = newCode;
    }

    public void SetLabel(string newLabel)
    {
        label = newLabel;
    }

    public void SetCost(double newCost)
    {
        if (newCost > 0)
            cost = newCost;
        else
            cost = 0;
    }

    // Abstract discount method
    public abstract double ComputeReduction();
}

// Electronics class
public class GadgetItem : ProductItem, ITaxable
{
    public override double ComputeReduction()
    {
        return Cost * 0.10; // 10% discount
    }

    public double CalculateTax()
    {
        return Cost * 0.18; // 18% GST
    }

    public string GetTaxReport()
    {
        return "Category → Electronics | GST → 18%";
    }
}

// Clothing class
public class WearableItem : ProductItem, ITaxable
{
    public override double ComputeReduction()
    {
        return Cost * 0.15; // 15% discount
    }

    public double CalculateTax()
    {
        return Cost * 0.05; // 5% GST
    }

    public string GetTaxReport()
    {
        return "Category → Clothing | GST → 5%";
    }
}

// Groceries class (Not taxable)
public class FoodBasketItem : ProductItem
{
    public override double ComputeReduction()
    {
        return Cost * 0.05; // 5% discount
    }
}

// Main class
public class ShopEngine
{
    // Polymorphic method to compute final price
    public static void PrintFinalBill(ProductItem[] cartList)
    {
        foreach (ProductItem element in cartList)
        {
            double discount = element.ComputeReduction();
            double tax = 0;

            if (element is ITaxable t)
            {
                tax = t.CalculateTax();
                Console.WriteLine(t.GetTaxReport());
            }
            else
            {
                Console.WriteLine("Category → Groceries | GST → Not Applied");
            }

            double finalPay = element.Cost + tax - discount;

            Console.WriteLine("\n--- Product Invoice ---");
            Console.WriteLine("ID        : " + element.Code);
            Console.WriteLine("Name      : " + element.Label);
            Console.WriteLine("Price     : ₹" + element.Cost);
            Console.WriteLine("Tax       : ₹" + tax);
            Console.WriteLine("Discount  : ₹" + discount);
            Console.WriteLine("Final Pay : ₹" + finalPay);
            Console.WriteLine("----------------------\n");
        }
    }

    public static void Main()
    {
        ProductItem[] storeRack = new ProductItem[3];

        // Electronics product
        GadgetItem p1 = new GadgetItem();
        p1.SetCode(7001);
        p1.SetLabel("Smart Watch");
        p1.SetCost(12000);

        // Clothing product
        WearableItem p2 = new WearableItem();
        p2.SetCode(7002);
        p2.SetLabel("Denim Jacket");
        p2.SetCost(2500);

        // Grocery product
        FoodBasketItem p3 = new FoodBasketItem();
        p3.SetCode(7003);
        p3.SetLabel("Organic Rice Pack");
        p3.SetCost(800);

        storeRack[0] = p1;
        storeRack[1] = p2;
        storeRack[2] = p3;

        Console.WriteLine("Generating Bills...\n");
        PrintFinalBill(storeRack);

        Console.WriteLine("Billing Completed!");
    }
}

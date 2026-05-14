using System;

class InvoiceGenerator
{
    public static string[] ParseInvoice(string input)
    {
        string[] parts = input.Split(',');
        for (int i = 0; i < parts.Length; i++)
        {
            parts[i] = parts[i].Trim();
        }
        return parts;
    }

    public static double GetTotalAmount(string[] tasks)
    {
        double total = 0;
        foreach (string task in tasks)
        {
            string[] detail = task.Split('-');
            if (detail.Length == 2)
            {
                string amount = detail[1].Trim();
                amount = amount.Replace("INR", "").Trim();
                total += Convert.ToDouble(amount);
            }
        }
        return total;
    }

    public static void GenerateInvoice(string[] tasks, double total)
    {
        Console.WriteLine("\n===== INVOICE DETAILS =====");
        foreach (string task in tasks)
        {
            string[] detail = task.Split('-');
            Console.WriteLine("Task: " + detail[0].Trim() + " | Amount: " + detail[1].Trim());
        }
        Console.WriteLine("Total Invoice Amount: " + total + " INR");
        Console.WriteLine("==========================");
    }
}

class Program
{
    static void Main()
    {
        // Store invoice data here (not static)
        string invoiceInput = "";
        string[] parsedTasks = null;
        double totalAmount = 0;

        while (true)
        {
            Console.WriteLine("\n===== FREELANCER INVOICE MENU =====");
            Console.WriteLine("1. Enter Invoice String");
            Console.WriteLine("2. Parse & Generate Invoice");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter invoice input (Example: Logo Design - 3000 INR, Web Page - 4500 INR): ");
                    invoiceInput = Console.ReadLine();
                    Console.WriteLine("Invoice string saved!");
                    break;

                case 2:
                    if (invoiceInput == "")
                    {
                        Console.WriteLine("⚠ Please enter invoice string first!");
                    }
                    else
                    {
                        parsedTasks = InvoiceGenerator.ParseInvoice(invoiceInput);
                        totalAmount = InvoiceGenerator.GetTotalAmount(parsedTasks);
                        InvoiceGenerator.GenerateInvoice(parsedTasks, totalAmount);
                    }
                    break;

                case 3:
                    Console.WriteLine("Thank you for using the Invoice Generator!");
                    return;

                default:
                    Console.WriteLine("❌ Invalid option! Try again.");
                    break;
            }
        }
    }
}

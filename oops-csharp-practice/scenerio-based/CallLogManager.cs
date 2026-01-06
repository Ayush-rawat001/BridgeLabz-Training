using System;

class CallLog
{
    public string PhoneNumber;
    public string Message;
    public DateTime Timestamp;

    public CallLog(string phone, string msg)
    {
        PhoneNumber = phone;
        Message = msg;
        Timestamp = DateTime.Now;
    }
}

class CallLogManager
{
    private CallLog[] logs;
    private int index;

    public CallLogManager(int size)
    {
        logs = new CallLog[size];
        index = 0;
    }

    public void AddCallLog(string phone, string msg)
    {
        if (index < logs.Length)
        {
            logs[index] = new CallLog(phone, msg);
            index++;
            Console.WriteLine("Log saved successfully!\n");
        }
        else
        {
            Console.WriteLine("Storage full! Cannot add more logs.\n");
        }
    }

    public void SearchByKeyword(string word)
    {
        Console.WriteLine("Search Results:\n----------------");
        bool found = false;

        for (int i = 0; i < index; i++)
        {
            if (logs[i].Message.Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Phone: {logs[i].PhoneNumber}");
                Console.WriteLine($"Message: {logs[i].Message}");
                Console.WriteLine($"Time: {logs[i].Timestamp}");
                Console.WriteLine("----------------");
                found = true;
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No matching logs found!\n");
    }

    public void FilterByTime(DateTime start, DateTime end)
    {
        Console.WriteLine("Filtered Logs:\n----------------");
        bool found = false;

        for (int i = 0; i < index; i++)
        {
            if (logs[i].Timestamp >= start && logs[i].Timestamp <= end)
            {
                Console.WriteLine($"Phone: {logs[i].PhoneNumber}");
                Console.WriteLine($"Message: {logs[i].Message}");
                Console.WriteLine($"Time: {logs[i].Timestamp}");
                Console.WriteLine("----------------");
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No logs found in this time range!\n");
    }
}

class program
{
    static void Main()
    {
        Console.Write("Enter max log capacity: ");
        int size = int.Parse(Console.ReadLine());

        CallLogManager manager = new CallLogManager(size);

        while (true)
        {
            Console.WriteLine("1. Add Call Log");
            Console.WriteLine("2. Search by Keyword");
            Console.WriteLine("3. Filter by Time Range");
            Console.WriteLine("4. Exit");
            Console.Write("\nChoose option: ");

            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter phone number: ");
                string phone = Console.ReadLine();

                Console.Write("Enter message: ");
                string msg = Console.ReadLine();

                manager.AddCallLog(phone, msg);
            }
            else if (option == 2)
            {
                Console.Write("Enter search keyword: ");
                string word = Console.ReadLine();
                manager.SearchByKeyword(word);
            }
            else if (option == 3)
            {
                Console.Write("Enter start date & time (yyyy-MM-dd HH:mm): ");
                DateTime start = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter end date & time (yyyy-MM-dd HH:mm): ");
                DateTime end = DateTime.Parse(Console.ReadLine());

                manager.FilterByTime(start, end);
            }
            else if (option == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice!\n");
            }
        }
    }
}

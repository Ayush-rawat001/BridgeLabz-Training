using System;

// A single student node
public class DataBlock
{
    public int key;
    public string label;
    public int level;
    public string value;
    public DataBlock bridge;

    public DataBlock(int roll, string name, int age, string grade)
    {
        key = roll;
        label = name;
        level = age;
        value = grade;
        bridge = null;
    }
}

// Linked list manager
public class DataBridgeList
{
    private DataBlock root;

    public void AddFront(int roll, string name, int age, string grade)
    {
        DataBlock newBlock = new DataBlock(roll, name, age, grade);
        newBlock.bridge = root;
        root = newBlock;
        Console.WriteLine("Record inserted at front.\n");
    }

    public void AddRear(int roll, string name, int age, string grade)
    {
        DataBlock newBlock = new DataBlock(roll, name, age, grade);

        if (root == null)
        {
            root = newBlock;
            Console.WriteLine("Record inserted as first entry.\n");
            return;
        }

        DataBlock runner = root;
        while (runner.bridge != null)
        {
            runner = runner.bridge;
        }

        runner.bridge = newBlock;
        Console.WriteLine("Record inserted at rear.\n");
    }

    public void AddPoint(int pos, int roll, string name, int age, string grade)
    {
        if (pos == 1)
        {
            AddFront(roll, name, age, grade);
            return;
        }

        DataBlock newBlock = new DataBlock(roll, name, age, grade);
        DataBlock runner = root;

        for (int i = 1; i < pos - 1; i++)
        {
            if (runner == null)
            {
                Console.WriteLine("Invalid position.\n");
                return;
            }
            runner = runner.bridge;
        }

        newBlock.bridge = runner.bridge;
        runner.bridge = newBlock;
        Console.WriteLine("Record inserted at position " + pos + "\n");
    }

    public void RemovePoint(int roll)
    {
        if (root == null)
        {
            Console.WriteLine("No records available.\n");
            return;
        }

        if (root.key == roll)
        {
            root = root.bridge;
            Console.WriteLine("Record removed.\n");
            return;
        }

        DataBlock runner = root;
        while (runner.bridge != null && runner.bridge.key != roll)
        {
            runner = runner.bridge;
        }

        if (runner.bridge == null)
        {
            Console.WriteLine("Record not found.\n");
            return;
        }

        runner.bridge = runner.bridge.bridge;
        Console.WriteLine("Record removed.\n");
    }

    public void SearchPoint(int roll)
    {
        DataBlock runner = root;
        while (runner != null)
        {
            if (runner.key == roll)
            {
                Console.WriteLine("\nRecord Found → " + runner.key + " | " + runner.label + " | " + runner.level + " | " + runner.value + "\n");
                return;
            }
            runner = runner.bridge;
        }
        Console.WriteLine("Record not found.\n");
    }

    public void UpdatePoint(int roll, string newGrade)
    {
        DataBlock runner = root;
        while (runner != null)
        {
            if (runner.key == roll)
            {
                runner.value = newGrade;
                Console.WriteLine("Record updated.\n");
                return;
            }
            runner = runner.bridge;
        }
        Console.WriteLine("Record not found.\n");
    }

    public void ShowAll()
    {
        if (root == null)
        {
            Console.WriteLine("No records to display.\n");
            return;
        }

        Console.WriteLine("\n--- All Records ---");
        DataBlock runner = root;
        while (runner != null)
        {
            Console.WriteLine(runner.key + " | " + runner.label + " | " + runner.level + " | " + runner.value);
            runner = runner.bridge;
        }
        Console.WriteLine("------------------\n");
    }
}

// Main runner class
public class StartApp
{
    public static void Main()
    {
        DataBridgeList store = new DataBridgeList();

        while (true)
        {
            Console.WriteLine("1. Add Student at Start");
            Console.WriteLine("2. Add Student at End");
            Console.WriteLine("3. Add Student at Position");
            Console.WriteLine("4. Delete Student by Roll No");
            Console.WriteLine("5. Search Student by Roll No");
            Console.WriteLine("6. Update Grade by Roll No");
            Console.WriteLine("7. Display All Students");
            Console.WriteLine("8. Exit");
            Console.Write("\nChoose option: ");

            int opt = Convert.ToInt32(Console.ReadLine());

            if (opt == 8)
            {
                Console.WriteLine("Exiting program...");
                break;
            }
            else if (opt == 1 || opt == 2 || opt == 3)
            {
                Console.Write("Enter Roll No: ");
                int roll = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Grade: ");
                string grade = Console.ReadLine();

                if (opt == 1)
                    store.AddFront(roll, name, age, grade);
                else if (opt == 2)
                    store.AddRear(roll, name, age, grade);
                else if (opt == 3)
                {
                    Console.Write("Enter Position: ");
                    int pos = Convert.ToInt32(Console.ReadLine());
                    store.AddPoint(pos, roll, name, age, grade);
                }
            }
            else if (opt == 4)
            {
                Console.Write("Enter Roll No to delete: ");
                int roll = Convert.ToInt32(Console.ReadLine());
                store.RemovePoint(roll);
            }
            else if (opt == 5)
            {
                Console.Write("Enter Roll No to search: ");
                int roll = Convert.ToInt32(Console.ReadLine());
                store.SearchPoint(roll);
            }
            else if (opt == 6)
            {
                Console.Write("Enter Roll No to update: ");
                int roll = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter new Grade: ");
                string grade = Console.ReadLine();

                store.UpdatePoint(roll, grade);
            }
            else if (opt == 7)
            {
                store.ShowAll();
            }
            else
            {
                Console.WriteLine("Invalid option.\n");
            }
        }
    }
}

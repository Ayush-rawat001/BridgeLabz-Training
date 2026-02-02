using System;

class HospitalUnit
{
    public string Name;
    public bool Available;
    public HospitalUnit Next;

    public HospitalUnit(string name, bool available = true)
    {
        Name = name;
        Available = available;
        Next = null;
    }
}

class AmbulanceRoute
{
    private HospitalUnit head;

    // Add hospital unit
    public void AddUnit(string name, bool available = true)
    {
        HospitalUnit newUnit = new HospitalUnit(name, available);

        if (head == null)
        {
            head = newUnit;
            newUnit.Next = head;
            return;
        }

        HospitalUnit temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }

        temp.Next = newUnit;
        newUnit.Next = head;
    }

    // Remove unit (maintenance)
    public void RemoveUnit(string name)
    {
        if (head == null) return;

        HospitalUnit curr = head;
        HospitalUnit prev = null;

        do
        {
            if (curr.Name == name)
            {
                if (prev != null)
                    prev.Next = curr.Next;
                else
                {
                    // Removing head
                    HospitalUnit last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                Console.WriteLine($"{name} is under maintenance and removed.");
                return;
            }

            prev = curr;
            curr = curr.Next;

        } while (curr != head);
    }

    // Find nearest available unit
    public void RedirectPatient()
    {
        if (head == null)
        {
            Console.WriteLine("No hospital units available.");
            return;
        }

        HospitalUnit temp = head;

        do
        {
            Console.WriteLine("Checking: " + temp.Name);

            if (temp.Available)
            {
                Console.WriteLine("Patient redirected to: " + temp.Name);
                return;
            }

            temp = temp.Next;

        } while (temp != head);

        Console.WriteLine("No available unit found.");
    }

    // Display route
    public void ShowRoute()
    {
        if (head == null) return;

        HospitalUnit temp = head;
        do
        {
            Console.Write(temp.Name + " → ");
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("(Back to " + head.Name + ")");
    }
}

class Program
{
    static void Main()
    {
        AmbulanceRoute route = new AmbulanceRoute();

        route.AddUnit("Emergency");
        route.AddUnit("Radiology", false);
        route.AddUnit("Surgery");
        route.AddUnit("ICU");

        route.ShowRoute();
        route.RedirectPatient();

        Console.WriteLine("\nRemoving Surgery (Maintenance)");
        route.RemoveUnit("Surgery");

        route.ShowRoute();
        route.RedirectPatient();
    }
}

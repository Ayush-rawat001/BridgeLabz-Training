using System;

class StageNode
{
    public string Stage;
    public StageNode Next;

    public StageNode(string stage)
    {
        Stage = stage;
        Next = null;
    }
}

class ParcelTracker
{
    private StageNode head;

    // Add stage at end
    public void AddStage(string stage)
    {
        StageNode newNode = new StageNode(stage);

        if (head == null)
        {
            head = newNode;
            return;
        }

        StageNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newNode;
    }

    // Add intermediate checkpoint after a given stage
    public void AddCheckpoint(string afterStage, string newStage)
    {
        StageNode temp = head;

        while (temp != null && temp.Stage != afterStage)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Stage not found. Cannot add checkpoint.");
            return;
        }

        StageNode checkpoint = new StageNode(newStage);
        checkpoint.Next = temp.Next;
        temp.Next = checkpoint;
    }

    // Forward tracking
    public void TrackParcel()
    {
        if (head == null)
        {
            Console.WriteLine("Parcel is lost. No tracking available.");
            return;
        }

        StageNode temp = head;
        while (temp != null)
        {
            Console.Write(temp.Stage);

            if (temp.Next != null)
                Console.Write(" → ");

            temp = temp.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        ParcelTracker tracker = new ParcelTracker();

        tracker.AddStage("Packed");
        tracker.AddStage("Shipped");
        tracker.AddStage("In Transit");
        tracker.AddStage("Delivered");

        tracker.TrackParcel();

        Console.WriteLine("\nAdding custom checkpoint...");
        tracker.AddCheckpoint("Shipped", "Warehouse Scan");

        tracker.TrackParcel();
    }
}

using System;

namespace TrafficManagerSystem
{
    // ---------------- VEHICLE NODE ----------------
    class VehicleNode
    {
        public string VehicleNumber;
        public VehicleNode Next;

        public VehicleNode(string number)
        {
            VehicleNumber = number;
            Next = null;
        }
    }

    // ---------------- CIRCULAR LINKED LIST ----------------
    class Roundabout
    {
        private VehicleNode head = null;

        // Add vehicle
        public void AddVehicle(string number)
        {
            VehicleNode newNode = new VehicleNode(number);

            if (head == null)
            {
                head = newNode;
                newNode.Next = head;
            }
            else
            {
                VehicleNode temp = head;
                while (temp.Next != head)
                    temp = temp.Next;

                temp.Next = newNode;
                newNode.Next = head;
            }

            Console.WriteLine($"Vehicle {number} entered roundabout.");
        }

        // Remove vehicle
        public void RemoveVehicle(string number)
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout empty.");
                return;
            }

            VehicleNode curr = head;
            VehicleNode prev = null;

            do
            {
                if (curr.VehicleNumber == number)
                {
                    if (curr == head)
                    {
                        // Only one vehicle
                        if (head.Next == head)
                        {
                            head = null;
                        }
                        else
                        {
                            VehicleNode last = head;
                            while (last.Next != head)
                                last = last.Next;

                            head = head.Next;
                            last.Next = head;
                        }
                    }
                    else
                    {
                        prev.Next = curr.Next;
                    }

                    Console.WriteLine($"Vehicle {number} exited roundabout.");
                    return;
                }

                prev = curr;
                curr = curr.Next;

            } while (curr != head);

            Console.WriteLine("Vehicle not found.");
        }

        // Print roundabout
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Roundabout is empty.");
                return;
            }

            VehicleNode temp = head;
            Console.Write("Roundabout: ");

            do
            {
                Console.Write(temp.VehicleNumber + " → ");
                temp = temp.Next;
            }
            while (temp != head);

            Console.WriteLine("(Back to Start)");
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }

    // ---------------- QUEUE ----------------
    class VehicleQueue
    {
        private string[] queue;
        private int front, rear, size, capacity;

        public VehicleQueue(int capacity)
        {
            this.capacity = capacity;
            queue = new string[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }

        public bool IsFull()
        {
            return size == capacity;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Enqueue(string vehicle)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue Overflow! Vehicle cannot enter.");
                return;
            }

            rear = (rear + 1) % capacity;
            queue[rear] = vehicle;
            size++;

            Console.WriteLine($"Vehicle {vehicle} waiting to enter.");
        }

        public string Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Underflow! No vehicles waiting.");
                return null;
            }

            string vehicle = queue[front];
            front = (front + 1) % capacity;
            size--;

            return vehicle;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Waiting queue empty.");
                return;
            }

            Console.Write("Waiting Queue: ");
            int i = front;

            for (int count = 0; count < size; count++)
            {
                Console.Write(queue[i] + " ");
                i = (i + 1) % capacity;
            }

            Console.WriteLine();
        }
    }

    // ---------------- TRAFFIC MANAGER ----------------
    class TrafficManager
    {
        private Roundabout roundabout;
        private VehicleQueue queue;

        public TrafficManager(int queueSize)
        {
            roundabout = new Roundabout();
            queue = new VehicleQueue(queueSize);
        }

        public void VehicleArrives(string number)
        {
            queue.Enqueue(number);
        }

        public void AllowEntry()
        {
            string vehicle = queue.Dequeue();
            if (vehicle != null)
                roundabout.AddVehicle(vehicle);
        }

        public void ExitVehicle(string number)
        {
            roundabout.RemoveVehicle(number);
        }

        public void DisplayStatus()
        {
            Console.WriteLine("\n----- CURRENT TRAFFIC STATUS -----");
            roundabout.Display();
            queue.Display();
            Console.WriteLine("----------------------------------\n");
        }
    }

    // ---------------- MAIN PROGRAM ----------------
    class Program
    {
        static void Main()
        {
            TrafficManager manager = new TrafficManager(5);

            manager.VehicleArrives("CAR-101");
            manager.VehicleArrives("CAR-102");
            manager.VehicleArrives("CAR-103");

            manager.AllowEntry();
            manager.AllowEntry();

            manager.DisplayStatus();

            manager.ExitVehicle("CAR-101");

            manager.VehicleArrives("CAR-104");
            manager.AllowEntry();

            manager.DisplayStatus();

            Console.ReadLine();
        }
    }
}

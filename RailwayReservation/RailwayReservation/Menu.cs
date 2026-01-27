using RailwayReservation.RailwayReservation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RailwayReservation.RailwayReservation
{
    internal class Menu
    {
        public void Start()
        {
            Passenger[] passengers = new Passenger[100];
            int count = 0;
            int choice;
            Random random = new Random();

            do
            {
                Console.WriteLine("\n RAILWAY RESERVATION SYSTEM ");
                Console.WriteLine("1. Add Passenger");
                Console.WriteLine("2. Display All Passengers");
                Console.WriteLine("3. Sort by PNR ");
                Console.WriteLine("4. Search by PNR ");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                       
                        int pnr = random.Next(1, 1000);

                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Enter Distance: ");
                        int Distance = int.Parse(Console.ReadLine());

                        

                        if (age >= 60)
                            passengers[count] = new SeniorPassenger(pnr, name, age,Distance);
                        else
                            passengers[count] = new JuniorPassenger(pnr, name, age,Distance);

                        count++;
                        Console.WriteLine("Passenger added successfully.");
                       
                        break;

                    case 2:
                        if (count == 0)
                        {
                            Console.WriteLine("No passengers available.");
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                                passengers[i].Display();
                        }
                        break;

                    case 3:
                        InsertionSort(passengers, count);
                        Console.WriteLine("Passengers sorted on the basis of PNR" );
                        break;

                    case 4:
                        Console.Write("Enter PNR to search: ");
                        int key = int.Parse(Console.ReadLine());

                        int index = BinarySearch(passengers, count, key);

                        if (index != -1)
                        {
                            Console.WriteLine("\nPassenger Found:");
                            passengers[index].Display();
                        }
                        else
                        {
                            Console.WriteLine("Passenger not found.");
                        }
                        break;

                    case 5:
                        
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 5);
        }
        static void InsertionSort(Passenger[] arr, int n)
        {
            for (int i = 1; i < n; i++)
            {
                Passenger key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].PNR > key.PNR)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }
        static int BinarySearch(Passenger[] arr, int n, int key)
        {
            InsertionSort(arr, n);

            int low = 0;
            int high = n - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid].PNR == key)
                    return mid;
                else if (arr[mid].PNR < key)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1;
        }

    }
}

       
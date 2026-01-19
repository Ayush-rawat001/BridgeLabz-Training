using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ParcelTracker.ParcelTracker
{
    internal class Menu
    {
        public void start()
        {
            Utility utility = new Utility();

            while (true) 
            {
                Console.WriteLine("=======Parcel Tracker=======\n");
                Console.WriteLine("1. Track Parcel");
                Console.WriteLine("2. Add Checkpoint");
                Console.WriteLine("3. Mark Parcel Lost");
                Console.WriteLine("4. Exit");

                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        utility.TrackParcel();
                        break;
                    case 2:
                        Console.Write("Add after stage: ");
                        string after = Console.ReadLine();

                        Console.Write("Checkpoint name: ");
                        string stage = Console.ReadLine();

                        utility.AddCheckpoint(after, stage);
                        break;

                    case 3:
                        Console.Write("Break tracking after stage: ");
                        string lostStage = Console.ReadLine();

                        utility.MarkParcelLost(lostStage);
                        break;

                    case 4:
                        return;

                }
            }
            
        }
    }
}

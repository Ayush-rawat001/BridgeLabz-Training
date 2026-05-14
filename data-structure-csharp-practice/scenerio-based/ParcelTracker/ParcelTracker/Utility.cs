using System;
using System.Collections.Generic;
using System.Text;

namespace ParcelTracker.ParcelTracker
{
    internal class Utility: IParcelStage
    {
        private Node head;

        // Create default delivery flow
        public Utility()
        {
            head = new Node("Packed");

            Node shipped = new Node("Shipped");
            Node transit = new Node("In Transit");
            Node delivered = new Node("Delivered");

            head.Next = shipped;
            shipped.Next = transit;
            transit.Next = delivered;
        }
        public void TrackParcel()
        {
            Node current = head;

            Console.WriteLine("\nParcel Tracking Status:\n");

            while (current != null)
            {
                Console.Write(current.Stage);

                // lost parcel check
                if (current.Next == null &&
                    current.Stage != "Delivered")
                {
                    Console.WriteLine("\n\n Parcel may be LOST or tracking data missing.");
                    return;
                }

                if (current.Stage == "Delivered")
                {   
                    Console.WriteLine("\n\n Parcel Delivered Successfully.");
                    return;
                }
                Console.Write(" -> ");
                current = current.Next;
            }
        }

        public void AddCheckpoint(string after,string stage)
        {
            Node current = head;

            while (current != null)
            {
                if (current.Stage.Equals(after,StringComparison.OrdinalIgnoreCase))
                 {
                    Node checkpoint = new Node(stage);
                    checkpoint.Next = current.Next;
                    current.Next = checkpoint;

                    Console.WriteLine("\nCheckpoint added successfully.");
                    return;
                }

                current = current.Next;
            }

            Console.WriteLine("\nStage not found.");
        }

        public void MarkParcelLost(string stage)
        {

            Node current = head;

            while (current != null)
            {
                if (current.Stage.Equals(stage,StringComparison.OrdinalIgnoreCase))
                {
                    current.Next = null;
                    Console.WriteLine("\nParcel tracking broken after: " + stage);
                    return;
                }

                current = current.Next;
            }
        }
    }
}

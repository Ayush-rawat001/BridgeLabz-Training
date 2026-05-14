using System;

namespace FitnessLeaderboard
{
    class Leaderboard : ILeaderboard
    {
        private Node head;

        // ✅ ADD USER
        public void AddUser(string name, int steps)
        {
            Node newNode = new Node(name, steps);

            if (head == null)
            {
                head = newNode;
                Console.WriteLine("User added successfully.\n");
                return;
            }

            Node temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
            Console.WriteLine("User added successfully.\n");
        }

        // ✅ UPDATE STEPS
        public void UpdateSteps(string name, int steps)
        {
            Node temp = head;

            while (temp != null)
            {
                if (temp.UserName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    temp.Steps = steps;
                    Console.WriteLine("Steps updated successfully.\n");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("User not found.\n");
        }

        // ✅ BUBBLE SORT
        private void BubbleSort()
        {
            if (head == null || head.Next == null)
                return;

            bool swapped;

            do
            {
                swapped = false;
                Node current = head;

                while (current.Next != null)
                {
                    if (current.Steps < current.Next.Steps)
                    {
                        int tempSteps = current.Steps;
                        string tempName = current.UserName;

                        current.Steps = current.Next.Steps;
                        current.UserName = current.Next.UserName;

                        current.Next.Steps = tempSteps;
                        current.Next.UserName = tempName;

                        swapped = true;
                    }

                    current = current.Next;
                }

            } while (swapped);
        }

        // ✅ DISPLAY LEADERBOARD
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Leaderboard is empty.\n");
                return;
            }

            BubbleSort();

            Node temp = head;
            int rank = 1;

            Console.WriteLine("\n🏆 FITNESS LEADERBOARD 🏆\n");

            while (temp != null)
            {
                Console.WriteLine($"Rank {rank}: {temp.UserName} -> {temp.Steps} steps");
                temp = temp.Next;
                rank++;
            }

            Console.WriteLine();
        }
    }
}

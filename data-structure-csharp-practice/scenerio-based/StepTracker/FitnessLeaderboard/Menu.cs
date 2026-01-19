using System;

namespace FitnessLeaderboard
{
    class Menu
    {
        private Leaderboard leaderboard;

        public Menu()
        {
            leaderboard = new Leaderboard();
        }

        public void ShowMenu()
        {
            int choice;

            do
            {
                Console.WriteLine("========== FITNESS APP MENU ==========");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Update Steps");
                Console.WriteLine("3. Display Leaderboard");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        AddUserMenu();
                        break;

                    case 2:
                        UpdateStepsMenu();
                        break;

                    case 3:
                        leaderboard.Display();
                        break;

                    case 4:
                        Console.WriteLine("Exiting application...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.\n");
                        break;
                }

            } while (choice != 4);
        }

        private void AddUserMenu()
        {
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();

            Console.Write("Enter steps: ");
            int steps = Convert.ToInt32(Console.ReadLine());

            leaderboard.AddUser(name, steps);
        }

        private void UpdateStepsMenu()
        {
            Console.Write("Enter user name: ");
            string name = Console.ReadLine();

            Console.Write("Enter updated steps: ");
            int steps = Convert.ToInt32(Console.ReadLine());

            leaderboard.UpdateSteps(name, steps);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTracker.FitTracker
{
    public class Menu
    {
        private WorkoutUtility _utility = new WorkoutUtility();
        private UserProfile _user;

        public void Start()
        {
            Console.WriteLine("Enter User Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Weight:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height:");
            double height = double.Parse(Console.ReadLine());

            _user = new UserProfile(name, height, weight, age);

            while (true)
            {
                Console.WriteLine("\n--- FitTrack Menu ---");
                Console.WriteLine("1. View Profile");
                Console.WriteLine("2. Add Cardio Workout");
                Console.WriteLine("3. Add Strength Workout");
                Console.WriteLine("4. Track Workouts");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        _user.DisplayProfile();
                        break;
                    case 2:
                        _utility.AddCardio();
                        break;
                    case 3:
                        _utility.AddStrength();
                        break;
                    case 4:
                        _utility.TrackWorkouts();
                        break;
                    case 5:
                        Console.WriteLine("Exiting FitTrack... Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid Option!");
                        break;
                }

            }

        }
    }
}

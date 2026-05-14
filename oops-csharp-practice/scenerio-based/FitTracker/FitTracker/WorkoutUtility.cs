using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTracker.FitTracker
{
    public class WorkoutUtility
    {
        private Workout[] _workouts = new Workout[20];
        private int _count = 0;

        public void AddWorkout(Workout workout)
        {
            if (_count < _workouts.Length)
            {
                _workouts[_count++] = workout;
                Console.WriteLine("Workout Added Successfully!");
            }
            else
            {
                Console.WriteLine("Workout Storage Full!");
            }
        }
        public void AddCardio()
        {
            Console.WriteLine("Enter Workout Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Duration (minutes):");
            int duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Calories Burned:");
            int calories = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Cardio Type (Running/Cycling/etc):");
            string type = Console.ReadLine();

            var cardio = new CardioWorkout(name, duration, calories, type);
            AddWorkout(cardio);
        }
        public void TrackWorkouts()
        {
            Console.WriteLine("\n--- Workout List ---");
            if (_count == 0)
            {
                Console.WriteLine("No workouts found!");
                return;
            }

            for (int i = 0; i < _count; i++)
            {
                _workouts[i].TrackWorkout();
            }
        }
        public void AddStrength()
        {
            Console.WriteLine("Enter Workout Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Duration (minutes):");
            int duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Calories Burned:");
            int calories = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Muscle Group (Chest/Arms/etc):");
            string muscle = Console.ReadLine();

            var strength = new StrengthWorkout(name, duration, calories, muscle);
            AddWorkout(strength);
        }


    }
}

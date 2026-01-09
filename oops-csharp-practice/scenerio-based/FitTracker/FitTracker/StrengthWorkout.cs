using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTracker.FitTracker
{
    public class StrengthWorkout:Workout
    {
        private string _muscleGroup;

        public StrengthWorkout(string name, int duration, int calories, string muscle)
            : base(name, duration, calories)
        {
            _muscleGroup = muscle;
        }

        public string GetMuscleGroup() => _muscleGroup;
        public void SetMuscleGroup(string muscle)
        {
            if (!string.IsNullOrWhiteSpace(muscle))
                _muscleGroup = muscle;
        }

        

        public override void TrackWorkout()
        {
            Console.Write("Strength : ");
            base.TrackWorkout();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTracker.FitTracker
{
    public abstract class Workout : ITrackable
    {
        private string _workoutName;
        private int _durationMinutes;
        private int _caloriesBurned;

        protected Workout(string name, int duration, int calories)
        {
            _workoutName = name;
            _durationMinutes = duration;
            _caloriesBurned = calories;
        }

        public string GetWorkoutName() => _workoutName;
        public void SetWorkoutName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                _workoutName = name;
        }

        public int GetDuration() => _durationMinutes;
        public void SetDuration(int duration)
        {
            if (duration > 0)
                _durationMinutes = duration;
        }

        public int GetCalories() => _caloriesBurned;
        public void SetCalories(int calories)
        {
            if (calories > 0)
                _caloriesBurned = calories;
        }

        public virtual void TrackWorkout()
        {
            Console.WriteLine($"{GetWorkoutName()} | Duration: {GetDuration()} min | Calories: {GetCalories()}");
        }


        
    }
}

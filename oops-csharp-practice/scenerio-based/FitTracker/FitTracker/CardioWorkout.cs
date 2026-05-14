using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTracker.FitTracker
{
    public class CardioWorkout:Workout
    {
        private string _cardioType;

          public CardioWorkout(string name, int duration, int calories, string type)
            : base(name, duration, calories)
        {
            _cardioType = type;
        }

        public string GetCardioType() => _cardioType;
        public void SetCardioType(string type)
        {
            if (!string.IsNullOrWhiteSpace(type))
                _cardioType = type;
        }

       

        public override void TrackWorkout()
        {
            Console.Write("Cardio : ");
            base.TrackWorkout();
        }
    }
}

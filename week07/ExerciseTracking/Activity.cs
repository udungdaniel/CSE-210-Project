using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public abstract class Activity
    {
        private string _date;
        protected int _minutes; // Change this to protected

        protected Activity(string date, int minutes)
        {
            _date = date;
            _minutes = minutes;
        }

        public abstract double GetDistance();
        public abstract double GetSpeed();
        public abstract double GetPace();

        public string GetSummary()
        {
            return $"{_date} {GetType().Name} ({_minutes} min) - " +
                   $"Distance: {GetDistance():F2}, Speed: {GetSpeed():F2}, Pace: {GetPace():F2}";
        }
    }
}
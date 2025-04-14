using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public class Swimming : Activity
    {
        private int _laps; // number of laps

        public Swimming(string date, int minutes, int laps) : base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return (_laps * 50 / 1000) * 0.62; // distance in miles
        }

        public override double GetSpeed()
        {
            double distance = GetDistance();
            return (distance / _minutes) * 60; // speed in mph
        }

        public override double GetPace()
        {
            double distance = GetDistance();
            return distance > 0 ? _minutes / distance : 0; // pace in min per mile
        }
    }
}
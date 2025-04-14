using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseTracking
{
    public class Running : Activity
    {
        private double _distance; // distance in miles

        public Running(string date, int minutes, double distance) : base(date, minutes)
        {
            _distance = distance;
        }

        public override double GetDistance()
        {
            return _distance;
        }

        public override double GetSpeed()
        {
            return (_distance / _minutes) * 60; // speed in mph
        }

        public override double GetPace()
        {
            return _minutes / _distance; // pace in min per mile
        }
    }
}
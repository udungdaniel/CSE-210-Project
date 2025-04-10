using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int _timesCompleted;
        private int _target;

        public ChecklistGoal(string name, int points, int target) : base(name, points)
        {
            _target = target;
            _timesCompleted = 0;
        }

        public int Target => _target; // Public property to access the target

        public int TimesCompleted => _timesCompleted; // Public property to access the number of times completed

        public override void RecordEvent()
        {
            if (!_isComplete)
            {
                _timesCompleted++;
                if (_timesCompleted >= _target)
                {
                    _isComplete = true;
                }
            }
        }

        public override string GetGoalStatus()
        {
            return _isComplete ? "[X] " + _name + " (Completed " + _timesCompleted + "/" + _target + " times)"
                              : "[ ] " + _name + " (Completed " + _timesCompleted + "/" + _target + " times)";
        }
    }
}
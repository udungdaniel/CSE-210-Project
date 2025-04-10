using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
    public class NegativeGoal : Goal
    {
        public NegativeGoal(string name, int points) : base(name, points) { }

        public override void RecordEvent()
        {
            _isComplete = true; // Mark as complete after recording
        }

        public override string GetGoalStatus()
        {
            return _isComplete ? "[X] " + _name : "[ ] " + _name;
        }
    }
}
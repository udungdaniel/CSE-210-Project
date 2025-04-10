using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        public SimpleGoal(string name, int points) : base(name, points) { }

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override string GetGoalStatus()
        {
            return _isComplete ? "[X] " + _name : "[ ] " + _name;
        }
    }
}
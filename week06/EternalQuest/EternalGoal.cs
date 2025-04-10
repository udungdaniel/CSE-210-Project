using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string name, int points) : base(name, points) { }

        public override void RecordEvent()
        {
            // No completion for eternal goals
        }

        public override string GetGoalStatus()
        {
            return "[ ] " + _name; // Always incomplete
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternalQuest
{
    public abstract class Goal
    {
        protected string _name;
        protected int _points;
        protected bool _isComplete;

        protected Goal(string name, int points)
        {
            _name = name;
            _points = points;
            _isComplete = false;
        }

        public abstract void RecordEvent();
        public abstract string GetGoalStatus();
        public string Name => _name;
        public int Points => _points;
        public bool IsComplete => _isComplete;
    }
}
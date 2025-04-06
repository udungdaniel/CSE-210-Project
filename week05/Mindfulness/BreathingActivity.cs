using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            _activityName = "Breathing Activity";
            _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        }

        public void Run()
        {
            StartActivity();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                ShowSpinner(4);
                Console.WriteLine("Breathe out...");
                ShowSpinner(4);
            }
            EndActivity();
        }
    }
}
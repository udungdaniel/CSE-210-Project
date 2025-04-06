using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Mindfulness
{
    public abstract class Activity
    {
        protected string _activityName;
        protected string _activityDescription;
        protected int _duration;

        public void StartActivity()
        {
            Console.WriteLine($"Starting {_activityName}...");
            Console.WriteLine(_activityDescription);
            Console.Write("Enter the duration in seconds: ");
            _duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Get ready to begin...");
            Pause(3);
        }

        public void EndActivity()
        {
            Console.WriteLine("Good job!");
            Pause(2);
            Console.WriteLine($"You completed the {_activityName} for {_duration} seconds.");
            Pause(3);
        }

        protected void Pause(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write($"\rPausing for {i} seconds... ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        protected void ShowSpinner(int duration)
        {
            int endTime = Environment.TickCount + (duration * 1000);
            while (Environment.TickCount < endTime)
            {
                Console.Write("/-\\|");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("\b");
                    Thread.Sleep(250);
                }
            }
            Console.WriteLine();
        }
    }
}
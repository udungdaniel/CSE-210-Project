using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class CreativeVisualizationActivity : Activity
    {
        public CreativeVisualizationActivity()
        {
            _activityName = "Creative Visualization Activity";
            _activityDescription = "This activity will help you visualize a peaceful scene or a goal you want to achieve. Allow your mind to wander and create a vivid picture.";
        }

        public void Run()
        {
            StartActivity();
            Console.WriteLine("Close your eyes and take a deep breath.");
            Pause(3);
            Console.WriteLine("Now, imagine a peaceful place. It could be a beach, a forest, or anywhere you feel calm.");
            Pause(5);
            Console.WriteLine("Visualize the details: the colors, the sounds, the smells.");
            Pause(5);
            Console.WriteLine("Now, think about a goal you want to achieve. Picture yourself accomplishing it.");
            Pause(5);
            Console.WriteLine("Feel the emotions associated with achieving this goal.");
            Pause(5);
            EndActivity();
        }
    }
}
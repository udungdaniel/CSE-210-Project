using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mindfulness
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            _activityName = "Listing Activity";
            _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        }

        public void Run()
        {
            StartActivity();
            Random random = new Random();
            string prompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine(prompt);
            Pause(5);

            Console.WriteLine("You have a few seconds to think about your response...");
            ShowSpinner(5);

            List<string> userResponses = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            Console.WriteLine("Start listing your items (type 'done' to finish):");

            while (DateTime.Now < endTime)
            {
                string response = Console.ReadLine();
                if (response.ToLower() == "done")
                {
                    break;
                }
                userResponses.Add(response);
            }

            Console.WriteLine($"You listed {userResponses.Count} items.");
            EndActivity();
        }
    }
}
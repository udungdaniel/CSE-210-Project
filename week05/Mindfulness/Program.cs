using System;
using Mindfulness; 

namespace Mindfulness
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the W05 Project: Mindfulness Program");
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Select an activity to start:");
                Console.WriteLine();
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Creative Visualization Activity");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice (1-5): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        new BreathingActivity().Run();
                        break;
                    case "2":
                        new ReflectionActivity().Run();
                        break;
                    case "3":
                        new ListingActivity().Run();
                        break;
                    case "4":
                        new CreativeVisualizationActivity().Run();
                        break;
                    case "5":
                        Console.WriteLine("Thank you for using the Mindfulness program. Goodbye!");
                        Console.WriteLine();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
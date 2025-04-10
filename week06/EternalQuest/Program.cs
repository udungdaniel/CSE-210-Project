using System;
using System.Collections.Generic;

namespace EternalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager goalManager = new GoalManager();
            string filePath = "goals.json"; // File path for saving/loading goals

            // Load existing goals if the file exists
            goalManager.LoadGoals(filePath);

            // Sample goals (if no goals loaded)
            if (goalManager.TotalScore == 0)
            {
                goalManager.AddGoal(new SimpleGoal("Run a marathon", 1000));
                goalManager.AddGoal(new EternalGoal("Read scriptures", 100));
                goalManager.AddGoal(new ChecklistGoal("Attend the temple", 50, 10));
                goalManager.AddGoal(new NegativeGoal("Stop eating junk food", 200)); // Example of a negative goal
            }

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nW06 Project: Eternal Quest Program Menu:");
                Console.WriteLine("-----------------------------------------\n");
                Console.WriteLine("1. Display Goals");
                Console.WriteLine("2. Record Goal Event");
                Console.WriteLine("3. Add New Goal");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        goalManager.DisplayGoals();
                        Console.WriteLine("Total Score: " + goalManager.TotalScore);
                        break;

                    case "2":
                        Console.Write("Enter the name of the goal to record: ");
                        string goalName = Console.ReadLine();
                        goalManager.RecordGoalEvent(goalName);
                        break;

                    case "3":
                        AddNewGoal(goalManager);
                        break;

                    case "4":
                        goalManager.SaveGoals(filePath);
                        Console.WriteLine("Goals saved successfully.");
                        break;

                    case "5":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static void AddNewGoal(GoalManager goalManager)
        {
            Console.WriteLine("Choose the type of goal to add:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Negative Goal");
            Console.Write("Enter your choice: ");
            string goalType = Console.ReadLine();

            Console.Write("Enter the name of the goal: ");
            string name = Console.ReadLine();
            Console.Write("Enter the points for the goal: ");
            int points = int.Parse(Console.ReadLine());

            switch (goalType)
            {
                case "1":
                    goalManager.AddGoal(new SimpleGoal(name, points));
                    break;

                case "2":
                    goalManager.AddGoal(new EternalGoal(name, points));
                    break;

                case "3":
                    Console.Write("Enter the target number of completions: ");
                    int target = int.Parse(Console.ReadLine());
                    goalManager.AddGoal(new ChecklistGoal(name, points, target));
                    break;

                case "4":
                    goalManager.AddGoal(new NegativeGoal(name, points));
                    break;

                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }
    }
}
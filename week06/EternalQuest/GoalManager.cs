using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        public int TotalScore { get; private set; }

        public GoalManager()
        {
            _goals = new List<Goal>();
            TotalScore = 0;
        }

        public void AddGoal(Goal goal)
        {
            _goals.Add(goal);
        }

        public void RecordGoalEvent(string goalName)
        {
            foreach (var goal in _goals)
            {
                if (goal.Name == goalName)
                {
                    goal.RecordEvent();
                    if (goal is NegativeGoal)
                    {
                        TotalScore -= goal.Points; // Deduct points for negative goals
                    }
                    else
                    {
                        TotalScore += goal.Points; // Add points for other goals
                    }
                    break;
                }
            }
        }

        public void DisplayGoals()
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetGoalStatus());
            }
        }

        public void SaveGoals(string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(_goals, options);
            File.WriteAllText(filePath, jsonString);
        }

        public void LoadGoals(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                // Deserialize the goals
                var loadedGoals = JsonSerializer.Deserialize<List<Goal>>(jsonString, new JsonSerializerOptions
                {
                    Converters =
                    {
                        new GoalConverter() // Custom converter to handle polymorphic deserialization
                    }
                });

                if (loadedGoals != null)
                {
                    _goals = loadedGoals;
                    TotalScore = CalculateTotalScore(); // Recalculate total score based on loaded goals
                }
            }
        }

        private int CalculateTotalScore()
        {
            int score = 0;
            foreach (var goal in _goals)
            {
                if (goal.IsComplete)
                {
                    score += goal.Points;
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    score += checklistGoal.Points * checklistGoal.TimesCompleted; // Add points for completed checklist goals
                }
            }
            return score;
        }
    }
}
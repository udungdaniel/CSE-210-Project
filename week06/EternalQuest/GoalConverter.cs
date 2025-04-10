using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EternalQuest
{
    public class GoalConverter : JsonConverter<Goal>
    {
        public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
            {
                var root = doc.RootElement;
                string goalType = root.GetProperty("GoalType").GetString();
                string name = root.GetProperty("Name").GetString();
                int points = root.GetProperty("Points").GetInt32();

                return goalType switch
                {
                    "SimpleGoal" => new SimpleGoal(name, points),
                    "EternalGoal" => new EternalGoal(name, points),
                    "ChecklistGoal" => new ChecklistGoal(name, points, root.GetProperty("Target").GetInt32()),
                    "NegativeGoal" => new NegativeGoal(name, points),
                    _ => throw new NotSupportedException($"Goal type {goalType} is not supported.")
                };
            }
        }

        public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            writer.WriteString("GoalType", value.GetType().Name);
            writer.WriteString("Name", value.Name);
            writer.WriteNumber("Points", value.Points);
            if (value is ChecklistGoal checklistGoal)
            {
                writer.WriteNumber("Target", checklistGoal.Target);
            }
            writer.WriteEndObject();
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    // Method to add a new journal entry
    public void AddEntry()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        string prompt = prompts[index];

        Console.WriteLine($"Question: {prompt}");
        Console.Write("Your answer: ");
        string response = Console.ReadLine();

        JournalEntry newEntry = new JournalEntry(prompt, response);
        entries.Add(newEntry);
        Console.WriteLine("Your entry has been saved successfully.");
    }

    // Method to display the journal entries
    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("There are no entries in the journal.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    // Method to save journal to a CSV file
    public void SaveJournalToCsv(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                // Write headers
                writer.WriteLine("Date,Prompt,Response");

                foreach (var entry in entries)
                {
                    string date = entry.Date.ToString("yyyy-MM-dd HH:mm:ss");
                    string prompt = EscapeCsvField(entry.Prompt);
                    string response = EscapeCsvField(entry.Response);

                    writer.WriteLine($"{date},{prompt},{response}");
                }
            }
            Console.WriteLine("Journal has been saved successfully as a CSV.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving: {ex.Message}");
        }
    }

    // Method to load journal from a CSV file
    public void LoadJournalFromCsv(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try
        {
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                reader.ReadLine();  // Skip header line

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = ParseCsvRow(line);  // Handle CSV row parsing
                    if (values.Length < 3) continue;  // Skip invalid rows

                    DateTime date = DateTime.Parse(values[0]);
                    string prompt = values[1];
                    string response = values[2];

                    entries.Add(new JournalEntry(prompt, response) { Date = date });
                }
            }
            Console.WriteLine("Journal has been loaded successfully from the CSV.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading: {ex.Message}");
        }
    }

    // Helper function to escape CSV fields (handles quotes and commas)
    private string EscapeCsvField(string field)
    {
        if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
        {
            field = "\"" + field.Replace("\"", "\"\"") + "\"";  // Escape quotes and commas
        }
        return field;
    }

    // Helper function to parse a CSV row
    private string[] ParseCsvRow(string row)
    {
        var values = new List<string>();
        bool insideQuotes = false;
        string currentField = "";

        for (int i = 0; i < row.Length; i++)
        {
            char c = row[i];

            if (c == '\"')
            {
                insideQuotes = !insideQuotes;
                if (i + 1 < row.Length && row[i + 1] == '\"')  // Skip escaped quotes
                {
                    currentField += "\"";
                    i++;  // Skip next quote
                }
            }
            else if (c == ',' && !insideQuotes)
            {
                values.Add(currentField);
                currentField = "";
            }
            else
            {
                currentField += c;
            }
        }
        values.Add(currentField);  // Add last field

        return values.ToArray();
    }
}

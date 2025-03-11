using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public void DisplayJournal()
        {
        if (entries.Count == 0)
        {
            Console.WriteLine("there is no entries in the journal.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
        }

        public void SaveJournalToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
            foreach (var entry in entries)
                {
                writer.WriteLine(entry.Date.ToString("yyyy-MM-dd HH:mm:ss"));
                writer.WriteLine(entry.Prompt);
                writer.WriteLine(entry.Response);
                writer.WriteLine();
                }
            }
            Console.WriteLine("Journal has been saved successfully.");
        }
        public void LoadJournalFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
            Console.WriteLine("File isn't found.");
            return;
            }
            entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
            string line;
            while ((line = reader.ReadLine()) != null)
                {
                    DateTime date = DateTime.Parse(line);
                    string prompt = reader.ReadLine();
                    string response = reader.ReadLine();
                    reader.ReadLine(); // Skip empty line

                    JournalEntry entry = new JournalEntry(prompt, response)
                     {
                    Date = date
                    };
                
                    entries.Add(entry);
                }
            }
            Console.WriteLine("Journal has been loaded successfully.");
        }
    }
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Hello World! This is the Journal Project.");
            Console.WriteLine();
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("------------");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to CSV");
            Console.WriteLine("4. Load journal from CSV");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter filename to save the data: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveJournalToCsv(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadJournalFromCsv(loadFilename);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Incorrect option, try again.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter key to return to the main menu");
                Console.ReadLine();
            }
        }
    }
}

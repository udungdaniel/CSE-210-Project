using System;
using ScriptureMemorizer;
class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
            Console.WriteLine("---------------------------------------------------\n");
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'exit' to close the program.");

            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
                break;

            scripture.HideRandomWords(2);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nThank you for your time to memorize scripture\n");
    }
}
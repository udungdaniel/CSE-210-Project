using System;
using System.Collections.Generic;
using ScriptureMemorizer; 

class Program
{
    static void Main()
    {
        // Get a random scripture
        Scripture scripture = GetRandomScripture();

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
        Console.WriteLine("\nThank you for your time to memorize scriptures.");
    }

    static Scripture GetRandomScripture()
    {
        List<(Reference, string)> scriptures = new List<(Reference, string)>
        {
            (new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            (new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."),
            (new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me."),
            (new Reference("Romans", 8, 28), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose.")
        };

        Random random = new Random();
        var (reference, text) = scriptures[random.Next(scriptures.Count)];
        return new Scripture(reference, text);
    }
}

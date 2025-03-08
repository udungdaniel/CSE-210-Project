using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();

         // Prompt for the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt for the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display the result in the required format
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        Console.WriteLine();
    }
}
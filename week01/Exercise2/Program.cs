using System;

class Program
{
    static void Main(string[] args)
    {
        // Print a welcome message to the user to introduce the program
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();

        // Ask the user to enter their grade percentage
        Console.Write("What is your grade percentage? ");
        
        // Read the user's input as a string and store it in the 'answer' variable
        string answer = Console.ReadLine();
        
        // Convert the string input to an integer so we can use it in calculations
        int percent = int.Parse(answer);

        // Create an empty string to store the letter grade (A, B, C, D, or F)
        string letter = "";

        // Check the grade percentage and assign a letter grade
        if (percent >= 90)
        {
            // If the grade is 90 or higher, the letter grade is 'A'
            letter = "A";
        }
        else if (percent >= 80)
        {
            // If the grade is between 80 and 89, the letter grade is 'B'
            letter = "B";
        }
        else if (percent >= 70)
        {
            // If the grade is between 70 and 79, the letter grade is 'C'
            letter = "C";
        }
        else if (percent >= 60)
        {
            // If the grade is between 60 and 69, the letter grade is 'D'
            letter = "D";
        }
        else
        {
            // If the grade is below 60, the letter grade is 'F'
            letter = "F";
        }

        // Display the letter grade to the user
        Console.WriteLine($"Your grade is: {letter}");
        
        // Check if the student passed (70 or higher)
        if (percent >= 70)
        {
            // If the grade is 70 or higher, the student passed
            Console.WriteLine("You have passed! Keep it up");
            Console.WriteLine();
        }
        else
        {
            // If the grade is below 70, the student did not pass
            Console.WriteLine("Study more and try again next time!");
            Console.WriteLine();
        }
    }
}

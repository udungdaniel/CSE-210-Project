using System;

class Program
{
    static void Main(string[] args)
    {
        // Print a greeting message to introduce the program
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();

        // For Parts 1 and 2, the user would input a "magic number" directly...
        // The following lines are commented out, as we are using a random number for this part.
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // For Part 3, we are generating a random number between 1 and 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); // Random number between 1 and 100

        // Initialize the guess variable to an invalid value (-1) so the loop runs at least once
        int guess = -1;

        // Start a while loop that continues until the user guesses the magic number
        while (guess != magicNumber)
        {
            // Prompt the user to enter their guess
            Console.Write("What is your guess? ");
            
            // Convert the user input to an integer and store it in the 'guess' variable
            guess = int.Parse(Console.ReadLine());

            // Check if the guess is lower, higher, or correct compared to the magic number
            if (magicNumber > guess)
            {
                // If the magic number is greater, tell the user to guess higher
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                // If the magic number is smaller, tell the user to guess lower
                Console.WriteLine("Lower");
            }
            else
            {
                // If the guess is correct, tell the user they guessed it right
                Console.WriteLine("You guessed it right!");
                Console.WriteLine();
            }
        }
    }
}

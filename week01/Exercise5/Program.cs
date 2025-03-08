using System;

class Program
{
    static void Main(string[] args)
    {
        // Display a welcome message to introduce the program
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();

        // Ask the user for their name and store the result in 'userName'
        string userName = PromptUserName();

        // Ask the user for their favorite number and store the result in 'userNumber'
        int userNumber = PromptUserNumber();

        // Call the 'SquareNumber' method to square the user's number and store the result in 'squaredNumber'
        int squaredNumber = SquareNumber(userNumber);

        // Display the result to the user, showing their name and the squared number
        DisplayResult(userName, squaredNumber);
    }

    // Method to ask the user for their name and return it
    static string PromptUserName()
    {
        // Prompt the user to enter their name
        Console.Write("Please what is your name: ");
        
        // Get the user's input (their name) and store it in a variable
        string name = Console.ReadLine();

        // Return the entered name
        return name;
    }

    // Method to ask the user for their favorite number and return it as an integer
    static int PromptUserNumber()
    {
        // Prompt the user to enter their favorite number
        Console.Write("Please what is your favorite number: ");
        
        // Get the user's input, convert it to an integer, and store it in a variable
        int number = int.Parse(Console.ReadLine());

        // Return the entered number
        return number;
    }

    // Method to square the user's number
    static int SquareNumber(int number)
    {
        // Multiply the number by itself to get the square
        int square = number * number;

        // Return the squared number
        return square;
    }

    // Method to display the result to the user, including their name and the squared number
    static void DisplayResult(string name, int square)
    {
        // Output the user's name along with the squared value of their number
        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine();
    }
}

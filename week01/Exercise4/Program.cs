using System;
using System.Collections.Generic; // We need this to use the List class

class Program
{
    static void Main(string[] args)
    {
        // Display a welcome message to introduce the program
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine();

        // Create a list to store the numbers that the user will enter
        List<int> numbers = new List<int>();

        // Initialize the variable for user input. -1 is used to make sure the loop runs at least once.
        int userNumber = -1;

        // Start a while loop that keeps asking for numbers until the user enters 0
        while (userNumber != 0)
        {
            // Prompt the user to enter a number (0 to quit)
            Console.Write("Enter a number (Enter 0 to quit): ");
            
            // Read the user's response from the console and store it as a string
            string userResponse = Console.ReadLine();
            
            // Convert the user's response to an integer
            userNumber = int.Parse(userResponse);
            
            // Add the number to the list only if it's not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Part 1: Compute the sum of all numbers in the list
        int sum = 0;

        // Loop through each number in the list and add it to the sum
        foreach (int number in numbers)
        {
            sum += number;  // Add the current number to the sum
        }

        // Display the sum of the numbers
        Console.WriteLine($"The sum of the numbers you typed is: {sum}");

        // Part 2: Compute the average of the numbers
        // To avoid integer division, we cast sum to a float so that we get a decimal result
        float average = ((float)sum) / numbers.Count;

        // Display the average of the numbers
        Console.WriteLine($"The average of the numbers you typed is: {average}");

        // Part 3: Find the max number in the list
        // We'll start by assuming the first number in the list is the maximum
        int max = numbers[0];

        // Loop through each number to check if it's greater than the current max
        foreach (int number in numbers)
        {
            if (number > max)
            {
                // If we find a number greater than the current max, update max
                max = number;
            }
        }

        // Display the maximum number
        Console.WriteLine($"The maximum number you typed is: {max}");
        Console.WriteLine();
    }
}

using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor that initializes to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor that initializes to top/1
    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    // Constructor that initializes to top/bottom
    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        numerator = top;
        denominator = bottom;
    }

    // Getter and Setter for numerator
    public int GetNumerator()
    {
        return numerator;
    }
    
    public void SetNumerator(int value)
    {
        numerator = value;
    }

    // Getter and Setter for denominator
    public int GetDenominator()
    {
        return denominator;
    }
    
    public void SetDenominator(int value)
    {
        if (value == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        denominator = value;
    }

    // Method to return fraction string representation
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to return decimal representation
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // Creating instances of Fraction
        Fraction f1 = new Fraction(); // 1/1
        Fraction f2 = new Fraction(5); // 5/1
        Fraction f3 = new Fraction(3, 4); // 3/4
        Fraction f4 = new Fraction(1, 3); // 1/3

        // Displaying results
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine();
    }
}

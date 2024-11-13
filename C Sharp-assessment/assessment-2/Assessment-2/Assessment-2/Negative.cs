using System;

public class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message) { }
}

public class Negative
{
    static void CheckNumber(int number)
    {
        if (number < 0)
        {
            throw new NegativeNumberException("Input number cannot be negative.");
        }
        else
        {
            Console.WriteLine("Input number is valid.");
        }
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            CheckNumber(number);
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
            
        }
        Console.Read();
    }
}
 
 
    
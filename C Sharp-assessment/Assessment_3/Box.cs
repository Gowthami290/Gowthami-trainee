
using System;

public delegate int Calculator(int x, int y);

class Program
{
    static int Add(int x, int y) => x + y;
    static int Subtract(int x, int y) => x - y;
    static int Multiply(int x, int y) => x * y;

    static void Calculate(Calculator calc, string operation)
    {
        Console.Write($"Enter first number for {operation}: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Enter second number for {operation}: ");
        int y = Convert.ToInt32(Console.ReadLine());
        int result = calc(x, y);
        Console.WriteLine($"{operation} result: {result}");
    }

    static void Main()
    {
        Console.WriteLine("Calculator Operations:");
        Calculator calcAdd = Add;
        Calculate(calcAdd, "Addition");

        Calculator calcSubtract = Subtract;
        Calculate(calcSubtract, "Subtraction");

        Calculator calcMultiply = Multiply;
        Calculate(calcMultiply, "Multiplication");
    }
}
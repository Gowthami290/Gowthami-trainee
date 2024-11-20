using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseessment_3
{
    public delegate int CalculatorOperation(int num1, int num2);
    class Program
    {
        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;
        static int Multiply(int x, int y) => x * y;
        static void Main()
        {
            //Calculator calcAdd = Add;
            //Calculator calcSubtract = Subtract;
            //Calculator calcMultiply = Multiply;
            Console.WriteLine("Calculator Operations:");
            Console.WriteLine($"Addition:calcAdd(4,5)");
            Console.WriteLine($"Subtraction:calcSubtract(4, 5)");
            Console.WriteLine($"Multiplication:calcMultiplication(4, 5)");




        }


    }
}

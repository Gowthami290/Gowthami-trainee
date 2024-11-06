using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word:");
            string userInput = Console.ReadLine();
            int length = userInput.Length;
            Console.WriteLine("The length of the given word is: {0}", length);
            Console.Read();
        }
    }
}
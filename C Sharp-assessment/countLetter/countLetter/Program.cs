using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countLetter
{
    class Program
    {
        static int CountLetterOccurrences(string str, char letter)
        {
            int Count = 0;
            foreach (char c in str.ToLower()) ;
            {
                if (c == Char.ToLower(letter)) Count++;
            }
            return Count;
        }
        static void Main()
        { 
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a string:");
            char letter = Console.ReadLine()[0];
            Console.WriteLine($"The letter'{letter}' appears{CountLetterOccurrences(str, letter)} times.");
        }
    }
}

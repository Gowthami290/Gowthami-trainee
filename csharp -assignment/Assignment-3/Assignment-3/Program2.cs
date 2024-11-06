using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
 
namespace Assignment_3

{

    class Program2

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter a word:");

            string userInput = Console.ReadLine();

            char[] charArray = userInput.ToCharArray();

            Array.Reverse(charArray);

            string reversedWord = new string(charArray);

            Console.WriteLine("The reversed word is:" + reversedWord);

            Console.Read();

        }

    }

}

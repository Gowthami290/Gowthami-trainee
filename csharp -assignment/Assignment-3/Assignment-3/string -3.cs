using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Assignment_3

{

    class Program3

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter first word:");

            string word1 = Console.ReadLine();

            Console.WriteLine("Enter second word:");

            string word2 = Console.ReadLine();

            if (word1.Equals(word2))

            {

                Console.WriteLine("Both the words are same");

            }

            else

            {

                Console.WriteLine("Both words are not same");

            }

            Console.Read();

        }

    }

}


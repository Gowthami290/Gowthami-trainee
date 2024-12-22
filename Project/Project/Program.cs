using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project
{
    class Program1
    {
        static void Main()
        {
            ChooseModule();
        }

        static void ChooseModule()
        {
            while (true)
            {
                Console.WriteLine("a. Admin");
                Console.WriteLine("b. User");
                Console.WriteLine("c. Exit");
                Console.Write("Enter your choice: ");
                
                string choice = Console.ReadLine()?.Trim().ToLower();

                switch (choice)
                {
                    case "a":
                        Admin.Menu();
                        break;

                    case "b":
                        User.UserOperations();
                        break;

                    case "c":
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }


    }
}


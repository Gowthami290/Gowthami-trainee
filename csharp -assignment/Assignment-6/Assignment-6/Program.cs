using System;
using CalculateLibrary;

namespace Assignment_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter userName for ticketbook:");
            string User_Name = Console.ReadLine();
            Console.WriteLine("Enter userAge for ticketbook:");
            int User_age = Convert.ToInt32(Console.ReadLine());
            Class1 calcobj = new Class1();
            calcobj.CalculateConcession(User_Name,User_age);
            Console.Read();
        }
    }
}

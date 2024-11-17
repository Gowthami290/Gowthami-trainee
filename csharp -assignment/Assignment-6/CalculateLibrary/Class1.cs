using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateLibrary
{
    public class Class1
    {
        public void CalculateConcession(string Username,int age)
        {
            const int totalfare= 500;
            
            if (age<=5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if(age>60)
            {
                Console.WriteLine("Senior Citizen"+"  "+ "Calculated Fare:" + (totalfare-(totalfare*30/100)));
            }
            else
            {
                Console.WriteLine("Ticket Booked " +"fare: " +totalfare);
            }


        }
    }
}
//Create a class library with a function CalculateConcession() 
//    that takes age as an input and calculates concession for travel as below:
//If age <= 5 then “Little Champs - Free Ticket” should be displayed
//If age > 60 then calculate 30% concession on the totalfare(Which is a constant Eg:500 / -) 
//    and Display “ Senior Citizen” + Calculated Fare
//Else “Print Ticket Booked” + Fare. 
//Create a Console application with a Class called Program which has TotalFare as Constant, Name, Age.
//Accept Name, Age from the user and call the CalculateConcession() function to test the Classlibrary functionality

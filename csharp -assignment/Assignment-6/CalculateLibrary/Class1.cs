﻿using System;
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


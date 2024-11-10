using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Scholarship
    {
        double Scholarship_amount;
        public void Merit(int marks, double fees)
        {
            if(marks>=70 && marks<=80)
            {
                 Scholarship_amount = fees + (double)20 / 100;
            }
            else if(marks>80 && marks<=90)
            {
                Scholarship_amount = fees = (double)30 / 100;
            }
            else if(marks>90)
            {
                Scholarship_amount = fees + (double)50 / 100;
            }
            
            Console.WriteLine("Scholarship amount is {0}", Scholarship_amount);
        }
        public void Main()
        {
            Console.WriteLine("Enter the marks of the student :");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of the student :");
            double fees = Convert.ToInt32(Console.ReadLine());
            Scholarship s = new Scholarship();
            s.Merit(marks, fees); 
            Console.Read();
        }

    }
}

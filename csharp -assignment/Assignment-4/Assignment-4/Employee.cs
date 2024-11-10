using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public float Salary;
        public Employee(int empid, string ename,float salary)
        {
            EmpId = empid;
            EmpName = ename;
            Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id : {0}, Employee Name : {1}, salary : {2}", EmpId, EmpName, Salary);
        }
    }
    class PartTimeEmployee : Employee
    {
        int Wages;
        public PartTimeEmployee(int empid,string ename, float salary) : base(empid, ename, salary)
        {

        }
        public static void Main()
        {
            Console.WriteLine("Enter the Employee Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Emter the EMpolyee salary");
            float sal = (float)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------Through Base class Constructor and Oblect----");
            Employee e1 = new Employee(id, name, sal);
            e1.Display();
            Console.WriteLine("-----Through Base class Constructor nd Object------");
            PartTimeEmployee p1 = new PartTimeEmployee(id, name, sal);
            p1.Display();
            Console.Read();
        }
    }
}

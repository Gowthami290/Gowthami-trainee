using System;

// Abstract class Student
public abstract class Student
{
    public string Name { get; set; }
    public string StudentId { get; set; }
    public double Grade { get; set; }

    public abstract bool IsPassed(double grade);
}

// Undergraduate class
public class Undergraduate : Student
{
    public override bool IsPassed(double grade)
    {
        return grade >= 70.0;
    }
}

// Graduate class
public class Graduate : Student
{
    public override bool IsPassed(double grade)
    {
        return grade >= 80.0;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Undergraduate name: ");
        string ugName = Console.ReadLine();
        Console.Write("Enter Undergraduate ID: ");
        string ugId = Console.ReadLine();
        Console.Write("Enter Undergraduate grade: ");
        double ugGrade = Convert.ToDouble(Console.ReadLine());

        Undergraduate ug = new Undergraduate
        {
            Name = ugName,
            StudentId = ugId,
            Grade = ugGrade
        };

        Console.Write("Enter Graduate name: ");
        string gName = Console.ReadLine();
        Console.Write("Enter Graduate ID: ");
        string gId = Console.ReadLine();
        Console.Write("Enter Graduate grade: ");
        double gGrade = Convert.ToDouble(Console.ReadLine());

        Graduate g = new Graduate
        {
            Name = gName,
            StudentId = gId,
            Grade = gGrade
        };

        Console.WriteLine($"{ug.Name} passed: {ug.IsPassed(ug.Grade)}");
        Console.WriteLine($"{g.Name} passed: {g.IsPassed(g.Grade)}");
        Console.Read();
    }
}
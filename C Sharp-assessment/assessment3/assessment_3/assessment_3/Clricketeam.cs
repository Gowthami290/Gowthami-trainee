using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment_3
{
    class Clricketeam
    {

        public class CricketTeam
        {
            public string TeamName { get; set; }
            public int Matches { get; set; }
            public int Sum { get; set; }
            public double Average { get; set; }

            public (int, int, double) PointsCalculation(int noOfMatches)
            {
                Sum = 0;
                for (int i = 0; i < noOfMatches; i++)
                {
                    Console.Write($"Enter score for match {i + 1}: ");
                    Sum += Convert.ToInt32(Console.ReadLine());
                }
                Matches = noOfMatches;
                Average = (double)Sum / noOfMatches;
                return (Matches, Sum, Average);
            }
        }

        class Program
        {
            static void Main()
            {
                CricketTeam team = new CricketTeam();
                team.TeamName = "RCB";
                Console.Write("Enter number of matches: ");
                int noOfMatches = Convert.ToInt32(Console.ReadLine());
                var (matches, sum, average) = team.PointsCalculation(noOfMatches);
                Console.WriteLine($"Team: {team.TeamName}, Matches: {matches}, Sum: {sum}, Average: {average}");
                Console.Read();

            }
        }
    }
}

   

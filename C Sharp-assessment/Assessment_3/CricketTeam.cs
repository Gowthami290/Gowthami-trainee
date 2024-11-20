using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asseessment_3
{
    public class CricketTeam
    {
        public string TeamName { get; set; }

        public int Matches { get; set; }
        public int Sum { get; set; }

        public double Average { get; set; }
        public (int, int, double) PointsCalculation(int noofMatches)
        {
            Sum = 0;
            for (int i = 0; i < noofMatches; i++)
            {
                Console.WriteLine($"Enter score for match{i + 1}:");
                Sum += Convert.ToInt32(Console.ReadLine());
            }
            Matches = noofMatches;
            Average = (double)Sum / noofMatches;
            return (Matches, Sum, Average);
        }

    }
    class program
    {
        static void main()
        {

            CricketTeam team = new CricketTeam();
            team.TeamName = "RCB";
            Console.WriteLine("Enter number of Matches:");
            int noofMatches = Convert.ToInt32(Console.ReadLine());
            var (matches, sum, average) = team.PointsCalculation(noofMatches);
            Console.WriteLine($"Team:{team.TeamName},matches:{matches},Sum:{sum},Average:{average}");
            Console.Read();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Asseessment_3
{
    class WorkspaceFile
    {
        static void main()
        {
            string filePath = "example.txt";
            Console.WriteLine("Enter text to append:");
            string text = Console.ReadLine();
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(text);
            }
            Console.WriteLine("Text appended successfully.");
            Console.WriteLine("Appended text:");
            Console.WriteLine(File.ReadAllText(filePath));
        }
    }
}

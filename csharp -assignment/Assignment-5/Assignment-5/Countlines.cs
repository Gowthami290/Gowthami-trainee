using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_5 
{
    class count
    {
        static void Main()
        {
            string p = "C:\\gowthami\\DotNet.Practise\\csharp -assignment\\Assignment-5\\csharp_file.txt";

          if (File.Exists(p))
            {
                int lineCount = File.ReadAllLines(p).Length;

                Console.WriteLine("The number of lines in program are :" + lineCount);
            }
            else 
            {
                Console.WriteLine("The specified path does not exist");
            } 
            Console.ReadLine();

        } 
    } 
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_5
{
    class strings1

    {
        static void Main()
        {
            string[] s = new string[3];
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write($"Enter string {i + 1} : ");
                s[i] = Console.ReadLine();
            }
            string path = "C:\\gowthami\\DotNet.Practise\\csharp -assignment\\Assignment-5\\Bommasani.txt";
            FileStream filestrem = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter streamwriter = new StreamWriter(filestrem);
            foreach (string S in s)
            {
                streamwriter.WriteLine(S);
            }
            Console.WriteLine("Written to the file Successfully");
            streamwriter.Flush();
            streamwriter.Close();
            filestrem.Close();
            Console.ReadLine();
        } 
    }
    
}

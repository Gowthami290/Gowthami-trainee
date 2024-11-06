using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frist_and_last
{
    class Program
    {
        static string SwapFristLastChars(string str)
        {
            if (str.Length <= 1)return str;
            return str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];
        }
        static void Main()
        {
            Console.WriteLine(SwapFristLastChars("abcd")); //dbca
            Console.WriteLine(SwapFristLastChars("a"));//a
            Console.WriteLine(SwapFristLastChars("xy"));//yx
            Console.Read();
        }
    }
}

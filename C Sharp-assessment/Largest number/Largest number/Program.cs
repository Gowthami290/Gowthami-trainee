using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Largest
{
    class Program
    {
        static int FindLargest(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }
        static void Main()
        {
            Console.WriteLine(FindLargest(1, 2, 3));//3
            Console.WriteLine(FindLargest(1, 2, 3));//3
            Console.WriteLine(FindLargest(1, 1, 1));//1
            Console.WriteLine(FindLargest(1, 2, 2));//2
            Console.Read();
        }
    }
}

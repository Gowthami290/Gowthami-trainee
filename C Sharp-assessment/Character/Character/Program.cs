using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character
{
    class Program
    {
      static string RemoveCharatposition(string str,int pos)
        {
            return str.Substring(0, pos) + str.Substring(pos,1);
        }
        static void Main()
        {
            Console.WriteLine(RemoveCharatposition("python",1));//pthon
            Console.WriteLine(RemoveCharatposition("python",0));//ython
            Console.WriteLine(RemoveCharatposition("python",4));//pythn
            Console.Read();
        }
    }
}

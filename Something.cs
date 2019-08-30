using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PATA = ProjectA.TeamA;
namespace ConsoleApplication2
{
    class Something
    {
        public static void Main(string[] args)
        {
            int i = 0;
            while (i != 1)
            {
            Start:
                    
                goto Start;
            }
        Console.Read();
        }
    }
}
namespace ProjectA
{
    class TeamA
    {
        public static void What()
        {
            Console.WriteLine("a");
        }
    }
}

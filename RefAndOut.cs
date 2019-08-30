using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace What
{
    class RefAndOut
    {
        static void Main(string[] args)
        {
            int n1, n2 = 5;
            Add(6, 5, out n1);
            Add(6, ref n2);
            Console.WriteLine(n1 + "," + n2);
            Console.Read();

        }
        public static void Add(int a, int b, out int c)
        {
            c = a + b;
            //the returned value is c which is equal to the sum of a and b
        }
        public static void Add(int a, ref int b)
        {
            b += a;
            //the returned value is b which is equal to itself plus a
        }
    }
}
using System;
using a = nesting.nested;
namespace nesting
{
    namespace nested
    {
        public class c
        {
            public static void print()
            {
                Console.WriteLine("Hey");
            }
        }
    }
}
class unNested
{
    public static void Main()
    {
        a.c.print();
        Console.Read();
    }
}
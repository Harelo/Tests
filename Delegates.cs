using System;
using System.Collections;

namespace ConsoleApplication2
{
    class Delegates
    {
        delegate void TestDel(int n);
        static void Main(string[] args)
        {
            TestDel testDel = (int n) => 
            { 
                Console.WriteLine(n); 
            };
            TestDel testDel2 = (int n) =>
                {
                    for (int i = 0; i < 5; i++)
                        Console.WriteLine(n);
                };
            testDel2(5);
            Console.Read();
        }
    }
}

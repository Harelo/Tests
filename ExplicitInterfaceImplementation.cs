using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface i1
    {
        void print();
    }
    interface i2
    {
        void print();
    }
    class ExplicitInterfaceImplementation : i1,i2
    {
        void i1.print()
        {
            Console.WriteLine("a");
        }
        void i2.print()
        {
            Console.WriteLine("b");
        }
        static void Main(string[] args)
        {
            ExplicitInterfaceImplementation example = new ExplicitInterfaceImplementation();
            ((i1)example).print();
            Console.Read();
        }
    }
}

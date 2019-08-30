using System;
using System.Reflection;

namespace Reflection
{
    public class ReflectionOne
    {
        public static void Main(string[] args)
        {
            Type T = Type.GetType("Reflection.Customer");
            Console.WriteLine("Full name: "+T.FullName);
            Console.WriteLine("Name: " + T.Name);
            Console.WriteLine("Namespace: " + T.Namespace);
            Console.WriteLine();
            Console.WriteLine("Properties in Customer: ");
            PropertyInfo[] properties = T.GetProperties();
            foreach(PropertyInfo p in properties)
            {
                Console.WriteLine(p.PropertyType.Name+" "+p.Name);
            }
            Console.WriteLine();
            Console.WriteLine("Methods in Customer: ");
            MethodInfo[] methods = T.GetMethods();
            foreach(MethodInfo m in methods)
            {
                Console.WriteLine(m.ReturnParameter + " " + m.Name);
            }
            Console.Read();
        }
    }
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public Customer(int Id, string Name)
        {
            this.id = Id;
            this.name = Name;
        }
        public Customer()
        {
            this.id = -1;
            this.name = string.Empty;
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.name);
        }
        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.id);
        }
    }
}

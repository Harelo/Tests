using System;
using System.Collections.Generic;
namespace a 
{
    public interface IsAPerson
    {
        void Subscribe();
    }
    class Customer : IsAPerson
    {
        public string name;
        public int age;
        public void Subscribe()
        {
            Console.WriteLine("Customer has paid 100 dollars and subscribed!");
        }
    }
    class Employee : IsAPerson
    {
        public string name;
        public int age;
        public void Subscribe()
        {
            Console.WriteLine("Employee has subscribed!");
        }
    }
    class mainClass
    {
        public static void Main(string[] args)
        {
            List<IsAPerson> a = new List<IsAPerson>();
            Customer George = new Customer();
            George.name = "George";
            George.age = 20;
            Employee Max = new Employee();
            Max.name = "Max";
            Max.age = 30;
            a.Insert(0, Max);
            a.Insert(1, George);
            a[0].Subscribe();
            a[1].Subscribe();
            int? c = 5;
            int? num1 = null;
            c = num1 ?? 3;
            Console.WriteLine(c);
            Console.Read();
        }
    }
}

using System;
using System.IO;

namespace Enums
{
    class Enums
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            a.age = 5;
            a.gender = Gender.Female;
            Console.WriteLine(a.gender);
            int[] values = (int[])Enum.GetValues(typeof(Gender));
            foreach (int v in values)
            {
                Console.WriteLine(v);
            }
            Console.Read();
        }
    }
    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
    public class Person
    {
        public int age { get; set; }
        public Gender gender { get; set; }
    }
}

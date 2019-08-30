using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harel
{
    class Indexers
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            Console.WriteLine(c[26]);
            Console.WriteLine(Add(5, 5, 5, 5, 5, 5));
            Console.Read();
        }
        public static int Add(int a, int b, params int[] rest)
        {
            int sum = a + b;
            foreach(int i in rest)
            {
                sum += i;
            }
            return sum;
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Gender { get; set; }
        public Employee(string name, int id, string gender)
        {
            Name = name;
            Id = id;
            Gender = gender;
        }
    }
    public class Company
    {
        private List<Employee> listEmployees;
        public Company()
        {
            listEmployees = new List<Employee>();
            listEmployees.Add(new Employee("George",26,"Male"));
            listEmployees.Add(new Employee("Mike", 40, "Male"));
            listEmployees.Add(new Employee("Mika", 32, "Female"));
            listEmployees.Add(new Employee("Veronica", 23, "Female"));
            listEmployees.Add(new Employee("Max", 46, "Male"));
            listEmployees.Add(new Employee("Uri", 29, "Male"));
        }
        public string this[int EmployeeId]
        {
            get
            {
                return listEmployees.FirstOrDefault((Employee emp) => emp.Id == EmployeeId).Name;
            }
            set
            {
                listEmployees.FirstOrDefault((Employee emp) => emp.Id == EmployeeId).Name = value;
            }
        }
    }
}

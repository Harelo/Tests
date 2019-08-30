using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class DictionaryDemo
    {
            static void Main(string[] args)
            {
                Customer[] customers = new Customer[3];
                customers[0] = new Customer() { id = 1, age = 26, name = "George" };
                customers[1] = new Customer() { id = 2, age = 34, name = "Max" };
                customers[2] = new Customer() { id = 3, age = 40, name = "Mika" };
                Dictionary<int, Customer> dic = customers.ToDictionary(cust => cust.id, cust => cust);
                foreach(KeyValuePair<int, Customer> kvp in dic)
                {
                    Console.WriteLine("Key: " + kvp.Key + ", Value: " + kvp.Value.name);
                }
                Console.Read();
            }
    }
    class Customer
    {
        public int id { get; set; }
        public int age { get; set; }
        public string name { get; set; }
    }
}

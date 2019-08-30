using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace What
{
    class FuncDelegate
    {
        static void Main(string[] args)
        {
            List<Customer> lst = new List<Customer>(){
                new Customer(){id=101,name="George"},
                new Customer() {id=102,name="Max"},
                                new Customer() {id=103,name="John"},
                                new Customer() {id=104,name="Many"}
            };
            Func<Customer, string> selector = customer => customer.name;
            IEnumerable<string> names = lst.Select(selector);
            foreach (string name in names)
                Console.Write(name+",");
            Console.Read();
        }
    }
    class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}

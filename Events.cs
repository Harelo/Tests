using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Events
    {
        public static void Main(string[] args)
        {
            Person p = new Person();
            //This makes the person p a subscriber to the event cashEvent
            p.cashEvent += p_cashEvent;
            p.cashEvent += () => { Console.WriteLine("Yes, he really does."); };
            p.AddCash(150);
            Console.Read();
        }

        static void p_cashEvent()
        {
            Console.WriteLine("Person has a hundered dollars!");
        }
    }
    class Person
    {
        public delegate void MyEventHandler();
        public event MyEventHandler cashEvent;
        private int cash;
        public int Cash
        {
            get
            {
                return cash;
            }
            set
            {
                cash = value;
                if (cash >= 100)
                {
                    if (cashEvent != null)
                    {
                        //Throws the event
                        cashEvent();
                    }
                }
            }
        }
        public void AddCash(int amount)
        {
            Cash += amount;
        }
    }
}

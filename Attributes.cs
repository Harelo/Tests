using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        public static void Main(string[] args)
        {
            newBlarg("Hello");
            Console.Read();
        }
        [Obsolete("Use new method 'newBlarg' instead", true)]
        public static void blarg()
        {
            Console.WriteLine("Hey!");
        }
        public static void newBlarg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    [DebuggerDisplay("Count = {count}")]
    class MyHashtable
    {
        public int count = 4;
    }
}

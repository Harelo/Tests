#define dad
using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
    class Program
    {
        #region Constructor

        public Program()
        {
        }

        #endregion

        #region qvack

        static void Main(string[] args)
        {
#if(dad)
            Console.WriteLine("Dad is defined!");
#else
                Console.WriteLine("what");
#endif
        }

        #endregion
    }
}
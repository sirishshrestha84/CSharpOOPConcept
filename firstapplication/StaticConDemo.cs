using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class StaticConDemo
    {
        static StaticConDemo()
        {
            Console.WriteLine("Static constructor is called");
        }
        static void Main()
        {
            Console.WriteLine("Main method is called:");
        }
    }
}

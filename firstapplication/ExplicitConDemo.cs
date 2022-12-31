using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class ExplicitConDemo
    {
        public ExplicitConDemo()
        {
            Console.WriteLine("Constructor is called.");
        }
        static void Main()    
        {
            ExplicitConDemo obj1 = new ExplicitConDemo();
            ExplicitConDemo obj2 = new ExplicitConDemo();
            ExplicitConDemo obj3 = new ExplicitConDemo();
            Console.ReadLine();
        }
    }
}

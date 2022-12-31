using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class ConstructorDemo
    {
        int x;
        static int y;
     
    static ConstructorDemo()
        {
            Console.WriteLine("Static constructor is called:");
        }

        public ConstructorDemo(int x)
        {
            this.x = x;
            Console.WriteLine("Non-static construtor is called");
        }

        static void Main()
        {
            Console.WriteLine("The main method is called");
            ConstructorDemo d1 = new ConstructorDemo(10);
            ConstructorDemo d2 = new ConstructorDemo(20);
            Console.WriteLine(y);
            Console.WriteLine(d1.x + " " + d2.x);
            Console.ReadLine();
        }
    }
}

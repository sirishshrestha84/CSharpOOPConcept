using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class ParameterizedConDemo
    {
        int x; 
        public ParameterizedConDemo(int i)
        {
            x = i;
            Console.WriteLine("Parameterized Constructor is called:"  +i);
        }

        public void Display()
        {
            Console.WriteLine("Value of x:" + x);
        }

        static void Main()
        {
            ParameterizedConDemo cd1 = new ParameterizedConDemo(10);
            ParameterizedConDemo cd2 = new ParameterizedConDemo(20);
            cd1.Display();
            cd2.Display();
            Console.ReadLine();
        }
    }
}

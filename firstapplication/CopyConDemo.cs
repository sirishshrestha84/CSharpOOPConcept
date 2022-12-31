using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class CopyConDemo
    {
        int x;
        public CopyConDemo(int i)
        {
            x = i;
        }

        public CopyConDemo(CopyConDemo obj) //copy constructor 
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine("value of x is:" + x);
        }
        static void Main()
        {
            CopyConDemo cd1 = new CopyConDemo(10);
            cd1.Display();
            CopyConDemo cd2 = new CopyConDemo(cd1);
            cd2.Display();
            Console.ReadLine();
        }
    }
}

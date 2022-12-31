using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class ParameterizedCondemo2
    {
        int x;
        public ParameterizedCondemo2(int i)
        {
            x = i;
            Console.WriteLine("Parameterlized constructor is called:" + i);
        }

        public void Display()
        {
            Console.WriteLine("Value of x:" + x);
        }

        static void Main()
        {
            ParameterizedCondemo2 cd1 = new ParameterizedCondemo2(10);
            cd1.Display();
            Console.ReadLine();
        }
    }
}

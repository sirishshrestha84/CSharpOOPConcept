using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class CopyConDemo6
    {
        int x;
        public CopyConDemo6(int i)
        {
            x = i;
            Console.WriteLine("The constructor is called:" + i);
        }
        public CopyConDemo6(CopyConDemo6 obj)
        {
            x = obj.x;
        }

        public void Display()
        {
            Console.WriteLine("The value of x is:" + x);
        }

        static void Main()
        {
            CopyConDemo6 cd1 = new CopyConDemo6(100);
            cd1.Display();
            CopyConDemo6 cd2 = new CopyConDemo6(cd1);
            cd2.Display();
            Console.ReadLine();
        }
    }
}

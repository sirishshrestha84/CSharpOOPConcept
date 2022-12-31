using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class CopyConDemo8
    {
        int x;
        public CopyConDemo8(int i)
        {
            x = i;
            Console.WriteLine("The constructor is called");
        }
        public CopyConDemo8(CopyConDemo8 obj)
        {
            x = obj.x;
        }
        public void Display()
        {
            Console.WriteLine("The value of x:" + x);
        }
        static void Main()
        {
            CopyConDemo8 cd1 = new CopyConDemo8(100);
            cd1.Display();
            CopyConDemo8 cd2 = new CopyConDemo8(cd1);
            cd2.Display();
            Console.ReadLine();

        }
    }
}

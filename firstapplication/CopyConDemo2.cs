using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class CopyConDemo2
    {
        int x;

        public CopyConDemo2(int i)
        {
            x = i;
            Console.WriteLine("The constructor is called:" + i);
        }

        public CopyConDemo2 (CopyConDemo2 obj)
        {
            x = obj.x;
        }

        public void Display()
        {
            Console.WriteLine("Value of x is displayed:" + x);

        }

        static void Main()
        {
            CopyConDemo2 cd1 = new CopyConDemo2(10);
            cd1.Display();
            CopyConDemo2 cd2 = new CopyConDemo2(cd1);
            cd2.Display();
            Console.ReadLine();
        }
    }
}

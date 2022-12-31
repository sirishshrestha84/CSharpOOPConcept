using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class CopyConDemo7
    {
        int x;
        public CopyConDemo7(int i)
        {
            x = i;
            Console.WriteLine("The constructor is called:" + i);
        }
        public CopyConDemo7(CopyConDemo7 obj)
        {
            x = obj.x;
        }

        public void Display()
        {
            Console.WriteLine("The value of x:" + x);
        }

        static void Main()
        {
            CopyConDemo7 cd1 = new CopyConDemo7(100);
            cd1.Display();
            CopyConDemo7 cd2 = new CopyConDemo7(cd1);
            cd2.Display();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class COpyConDemo3
    {
        int x;

        public COpyConDemo3(int i)
        {
            x = i;
            Console.WriteLine("The constructor is called" + i);
        }

        public COpyConDemo3 (COpyConDemo3 obj)
        {
            x = obj.x;
        }
        
        public void Display()
        {
            Console.WriteLine("The value of x:" + x);
        }

        static void Main()
        {
            COpyConDemo3 cd1 = new COpyConDemo3(10);
            cd1.Display();
            COpyConDemo3 cd2 = new COpyConDemo3(cd1);
            cd2.Display();
            Console.ReadLine();
        }
    }
}

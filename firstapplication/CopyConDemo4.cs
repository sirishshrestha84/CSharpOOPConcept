using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class CopyConDemo4
    {
        int x;
      public CopyConDemo4(int i)
        {
            x = i;
            Console.WriteLine("The constructor is called:" + i);
        }

        public CopyConDemo4 (CopyConDemo4 obj)
        {
            x = obj.x;
        }
        
       public void Display()
        {
            Console.WriteLine("The value of x:" + x);
        }

       static void Main()
        {
            CopyConDemo4 cd1 = new CopyConDemo4(10);
            cd1.Display();
            CopyConDemo4 cd2 = new CopyConDemo4(cd1);
            cd2.Display(); 
            Console.ReadLine();
        }
    }
}

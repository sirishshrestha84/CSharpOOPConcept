using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class Fifth
    {
        int x;
        public Fifth(int x)
        {
            this.x = x;
        }

        class Testcl
        {
            static void Main()
            {
                Fifth f1 = new Fifth(100);
                Fifth f2 = new Fifth(200);
                Console.WriteLine(f1.x + " " + f2.x);
                Console.ReadLine();
            }
        }
    }
}

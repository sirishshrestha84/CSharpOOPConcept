using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class First2
    {
        public int x;
        public First2(int x)
        {
            this.x = x;
        }
    
    class Test
        {
            static void Main()
            {
                First2 f1 = new First2(100);
                First2 f2 = new First2(200);
                Console.WriteLine(f1.x + " " +f2.x);
                Console.ReadLine();

            }
        }
    }
}

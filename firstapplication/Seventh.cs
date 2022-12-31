using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class Seventh
    {
        int x;
        static int y;

    static Seventh()
        {
            Console.WriteLine("The static constructor is called");
        }
    public Seventh(int x)
        {
            this.x = x;
        }
    class Tested
        {

            static void Main()
            {
                Seventh d1 = new Seventh(10);
                Seventh d2 = new Seventh(20);
                Console.WriteLine(d1.x + " " + d2.x);
                Console.ReadLine();
            }
        }
    }
}

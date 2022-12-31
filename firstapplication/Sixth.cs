using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class Sixth
    {
        int x;
        public Sixth(int x)
        {
            this.x = x;
        }
        class TestClassess
        {
            static void Main()
            {
                Sixth s1 = new Sixth(100);
                Sixth s2 = new Sixth(200);
                Console.WriteLine(s1.x + " " + s2.x);
                Console.ReadLine();
            }
        }

    }
}

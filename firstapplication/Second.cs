using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class Third
    {
        int x;
        public Third(int x)
        {
            this.x = x;
        }

    class Classes
        {
            static void Main()
            {
                Third t1 = new Third(100);
                Third t2 = new Third(200);
                Console.WriteLine(t1.x + " " + t2.x);
                Console.ReadLine();
            }
        }
    }
}

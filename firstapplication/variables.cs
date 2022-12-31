using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class variables
    {
        int x ;
        static int y=200;
        readonly bool flag;
        public variables(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main()
        {
            variables v1 = new variables(100,true);
            variables v2 = new variables(200, false);
            Console.WriteLine(v1.x+ " " +v2.x);
            Console.WriteLine(v1.flag + " " + v2.flag);
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}

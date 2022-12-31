using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class AbsChild:AbsParent
    {
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            AbsChild c = new AbsChild();
            AbsParent p = c;
            p.Add(150, 10);
            p.Sub(150, 10);
            p.Mul(150, 10);
            p.Div(150, 10);
            Console.ReadLine();
        }
    }
}

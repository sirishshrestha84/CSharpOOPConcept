using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    public class Accessmodifie
    {
            private void Test1()
            {
                Console.WriteLine("Private Method");
            }
            internal void Test2()
            {
                Console.WriteLine("Internal Method");
            }
            protected void Test3()
            {
                Console.WriteLine("Protected Method");
            }
            protected internal void Test4()
            {
                Console.WriteLine("Protected internal Method");
            }
            public void Test5()
            {
                Console.WriteLine("Public Method");
            }

            static void Main()
            {
                Accessmodifie p = new Accessmodifie();
                p.Test1(); p.Test2(); p.Test3(); p.Test4();
                p.Test5();
                Console.ReadLine();
            }
    }
}


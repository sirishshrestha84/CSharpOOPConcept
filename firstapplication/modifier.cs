using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Child class of accessmodifie. 
namespace firstapplication
{
    class modifier: Accessmodifie
    {
        static void Main()
        {
            modifier p = new modifier();
            p.Test2(); p.Test3(); p.Test4();p.Test5();
            Console.ReadLine();
        }
    }
}

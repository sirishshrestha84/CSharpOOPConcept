using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class CopyConDemo5
    {
        int x;
        public CopyConDemo5(int i)
        {
            x = i;
            Console.WriteLine("The constructor is called:" + i);
        }
    public CopyConDemo5(CopyConDemo5 obj)
        {
            obj.x = x;
        }

    public void Display()
        {
            Console.WriteLine("The value of x:" +x);
        }

    static void Main()
        {
            CopyConDemo5 cd1 = new CopyConDemo5(100);
            cd1.Display();
            CopyConDemo5 cd2 = new CopyConDemo5(cd1);
            cd2.Display();
            Console.ReadLine();
        }
    }
}

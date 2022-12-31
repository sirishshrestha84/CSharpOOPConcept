using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class Operatoroverride: Object
    {
        int a, b, c, d;
        public Operatoroverride(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static Operatoroverride operator +(Operatoroverride obj1, Operatoroverride obj2)
        {
            Operatoroverride obj = new Operatoroverride(obj1.a+obj2.a,obj1.b+obj2.b,obj1.c+obj2.c,obj1.d+obj1.d);
            return obj;
        }

        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d+ "\n";
        }
        static void Main()
        {

        }


    }

    class Operatortest
    {
        static void Main()
        {
            Operatoroverride m1 = new Operatoroverride(1, 2, 3, 4);
            Operatoroverride m2 = new Operatoroverride(1, 2, 3, 4);
            Operatoroverride m3 = m1 + m2;
            Console.WriteLine(m3);
            Console.ReadLine();
        }
    }
}

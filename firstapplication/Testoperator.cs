using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace firstapplication
{
    internal class Testoperator :Object
    {
        int a, b, c, d;
        public Testoperator(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + "\n ";
        }
        public static Testoperator operator +(Testoperator obj1,Testoperator obj2)
        {
            Testoperator obj = new Testoperator(obj1.a+obj2.a,obj1.b+obj2.b,obj1.c+obj2.c,obj1.d+obj2.d);
            return obj;
        }

        static void Main()
        {
        }
    }

    class Testmatrix
    {
        static void Main()
        {
            Testoperator m1 = new Testoperator(20, 18, 16, 14);
            Testoperator m2 = new Testoperator(10, 8, 6, 4);
            Testoperator m3 = m1 + m2;
            Console.WriteLine(m3);
            Console.ReadLine();
        }
    }
}

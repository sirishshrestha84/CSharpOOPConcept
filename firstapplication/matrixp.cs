using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class matrixp:Object
    {
        int a, b, c, d;
        public matrixp(int a, int b, int c,int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static matrixp operator +(matrixp obj1, matrixp obj2)
        {
            matrixp obj = new matrixp(obj1.a + obj1.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }
        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + " \n";
        }
    }

class matrixpratice
    {
        static void Main()
        {
            matrixp m = new matrixp(1, 2, 3, 4);
            matrixp m1 = new matrixp(1, 2, 3, 4);
            matrixp m2 = m + m1;
            Console.WriteLine(m2);
            Console.ReadLine();
        }
    }
}

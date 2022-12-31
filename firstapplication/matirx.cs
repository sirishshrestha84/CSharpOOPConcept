using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class matirx
    {
        int a, b, c, d;
        public matirx(int a, int b, int c,int d)
        {
            this.a = a; 
            this.b = b; 
            this.c = c;
            this.d = d;
        }

        public static matirx operator +(matirx obj1, matirx obj2)
        {
            matirx obj = new matirx(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj1.d);
            return obj;
        }

        public override string ToString()
        {
            return a + " " + b + "\n" + c + " " + d + "\n";
        }
        static void Main()
        {

        }
    }
    class testmatrix
    {
        static void Main()
        {
            matirx m1 = new matirx(1, 2, 3, 4);
            matirx m2 = new matirx(1, 2, 3, 4);
            matirx m3 = m1 + m2;
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.ReadLine();
        } 
    }
}

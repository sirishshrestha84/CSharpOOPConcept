using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class mat:Object
    {
        int a, b, c, d;
        public mat(int a, int b, int c,int d)
        {
            this.a = a; 
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public static mat operator +(mat obj1, mat obj2)
        {
            mat obj = new mat(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }
        public override string ToString()
        {
            return +a+" " + b + "\n" + c + " " + d + "\n";
        }

        static void Main()
        {
            mat m = new mat(1, 2, 3, 4);
            mat m1 = new mat(1, 2, 3, 4);
            mat m2 = m + m1;
            Console.WriteLine(m);
            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.ReadLine();
        }
    }
}

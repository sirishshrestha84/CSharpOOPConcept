using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class Extentionmethod
    {
        public void Test1()
        {
            Console.WriteLine("Method1");
        }
        public void Test2()
        {
            Console.WriteLine("Method2");
        }
        static void Main()
        {
            Extentionmethod e = new Extentionmethod();
            e.Test1();
            e.Test2();
            e.Test3();

            int i = 5;
            long result = i.Factorial();
            Console.WriteLine(result);

            String str = "hOw ArE YOU?";
            str=str.ToProper();
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}

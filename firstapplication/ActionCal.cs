using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class ActionCal
    {
        static void Main()
        {
            string s = "";

            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i= 1; i < 1000000; i++)
            {
                s = s + i;
            }

            sw1.Stop();

            StringBuilder sb = new StringBuilder();
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 1; i < 1000000; i++)
            {
                sb.Append(i);
            }
            sw2.Stop();
            Console.WriteLine(+sw1.ElapsedMilliseconds);
            Console.WriteLine(+sw2.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace firstapplication
{
    public delegate string GreetingDelegate(string name);
    internal class AnonymousDelegates
    {
        static void Main()
        {
            GreetingDelegate g = delegate (string name)
            {
                return "Hello" + name + "a very good morning";
            };
            string str = g.Invoke("Sirish");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}

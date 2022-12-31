using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    //Define delegates
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string name);
    internal class Delegates
    {
        public void AddNums(int a, int b)
        {
        Console.WriteLine(a+b);
        }
        public static string SayHello(string name)
        {
            return "hello" + name;
        }
        static void Main()
        {
            Delegates d = new Delegates();
            d.AddNums(100, 50);
            string str = Delegates.SayHello("Sirish");
            Console.WriteLine(str);

            //Instanting the delegates
            AddDelegate ad = new AddDelegate(d.AddNums);
            //calling the delegates
            ad(100, 50);
            SayDelegate sd = new SayDelegate(SayHello);
            string str2 = sd("Raju");
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}

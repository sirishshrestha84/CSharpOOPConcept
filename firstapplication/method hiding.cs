using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal class method_hiding
    {
        public virtual void Test1()
        {
            Console.WriteLine("Parent's method 1st");
        }
        public void Test2()
        {
            Console.WriteLine("Parent's method 2nd");
        }
    }
    class ChildClass: method_hiding
    {
        public override void Test1()
        {
            Console.WriteLine("Child's' 1st method");
        }
        public new void Test2()
        {
            Console.WriteLine("Child's' 2st method");
        }
        static void Main()
        {
            ChildClass c = new ChildClass();// c is instance of child
            method_hiding p = c;//p is reference of parent class created using child instance
            c.Test1();
            c.Test2();
            p.Test1();//invokes child class method
            p.Test2();//invoke parent class method
            Console.ReadLine();
        }
    }
}

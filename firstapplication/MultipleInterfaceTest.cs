using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    interface Interface1
    {
        void Test();
        void Show();
    }

    interface Interface2
    {
        void Test();
        void Show();
    } 
    class MultipleInterfaceTest: Interface1,Interface2
    {
        public void Test()
        {
            Console.WriteLine("Interface method implemented");
        }
        void Interface1.Show()
        {
            Console.WriteLine("Interface show method implemented");
        }
        void Interface2.Show()
        {
            Console.WriteLine("Interface show method implemented");
        }
        static void Main()
        {
            MultipleInterfaceTest obj = new MultipleInterfaceTest();
            obj.Test();
            Interface1 i1 = obj; i1.Show();
            Interface2 i2 = obj;i2.Show();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace firstapplication
{
    internal class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent's show method is called");
        }
        public virtual void Test()
        {
            Console.WriteLine("Parent's test method is called");
        }
    }
    class LoadChild:LoadParent
    {
        public void Show(int i)
        {
            Console.WriteLine("Child's show method is called");
        }
        public override void Test()
        {
            Console.WriteLine("Child's test method is called");
        }
        static void Main()
        {
            {
                LoadChild c = new LoadChild();
                c.Show();
                c.Test();
                c.Show(10);
                Console.ReadLine();
            } 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    public abstract class abstractme
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }
    class Rectangless : abstractme
    {
        public Rectangless(double Width, double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Height * Width;
        }
    }
    class Testfig
    {
        public void Main()
        {
            Rectangless r = new Rectangless(1, 2);
            Console.WriteLine("The area of Rectangle:" + r.GetArea());
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    internal abstract class Figure
    {
        public double Width, Height;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }

    class Rectangle:Figure
    {
        public Rectangle(double Widht, double Height)
        {
            this.Width = Widht;
            this.Height = Height;   
        }
        public override double GetArea()
        {
            return Height * Width;
        }
        static void Main()
        {
            Rectangle r = new Rectangle(12.67, 56.78);
            Console.WriteLine("Area of rectangle:" +r.GetArea());
        }
    }
}

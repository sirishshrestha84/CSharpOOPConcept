using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstapplication
{
    public delegate void RectDelegate(double Width, double Height);
    internal class Triangle
    {
        public void GetArea(Double Width,double Height)
        {
            Console.WriteLine("Area of rectange:" +Width * Height);
        }
        public void GetPerimeter(double Width,double Height)
        {
            Console.WriteLine("Perimeter of rectangle:" +2 * (Width + Height));
        }
        static void Main()
        {
            Triangle rect = new Triangle();
            rect.GetArea(12.34, 56.78);
            rect.GetPerimeter(12.43, 56.78);

            RectDelegate obj = new RectDelegate(rect.GetArea);
            obj += rect.GetPerimeter;
            obj.Invoke(12.34, 56.78);
            Console.ReadLine();
        }
    }
}

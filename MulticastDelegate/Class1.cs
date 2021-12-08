using System;

namespace MulticastDelegate
{
    public delegate void RectangleDelegate(double height,double width);
    public class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area is {0}", (Width * Height));
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter is {0}", (2 * (Width + Height)));
        }
    }
}

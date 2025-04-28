using Homework02.App.Interfaces;

namespace Homework02.App.Class
{
    public class Rectangle : IShape
    {
        public Rectangle(double width, double height)
        {
            Width=width;
            Height=height;
        }

        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }
}

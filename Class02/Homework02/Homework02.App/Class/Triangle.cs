using Homework02.App.Interfaces;

namespace Homework02.App.Class
{
    public class Triangle : IShape
    {
        public Triangle(double baseLenght, double height)
        {
            BaseLenght=baseLenght;
            Height=height;
        }

        public double BaseLenght { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return BaseLenght * Height;
        }
    }
}

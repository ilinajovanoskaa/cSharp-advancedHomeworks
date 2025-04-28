using Homework02.App.Abstractions;
using Homework02.App.Interfaces;

namespace Homework02.App.Class
{
    public class Circle : IShape
    {
        public Circle(double radius)
        {
            Radius=radius;
        }

        public double Radius { get; set; }

        public double GetArea()
        {
            return Radius;
        }
    }
}

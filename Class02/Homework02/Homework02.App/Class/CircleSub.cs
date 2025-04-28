using Homework02.App.Abstractions;

namespace Homework02.App.Class
{
    public class CircleSub : Shape

    {
        public double Radius { get; set; }
        public CircleSub(double radius) 
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        { 
            return 2 * Math.PI * Radius;
        }
    }
}

using Homework02.App.Abstractions;

namespace Homework02.App.Class
{
    public class TriangleSub : Shape
    {
        public TriangleSub(double side1, double side2, double side3)
        {
            Side1=side1;
            Side2=side2;
            Side3=side3;
        }

        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        public override double CalculateArea()
        {
            double s = (Side1 + Side2 + Side3) / 2; 
            return (s * (s - Side1) * (s - Side2) * (s - Side3)); 
        }

        public override double CalculatePerimeter()
        {
            return Side1 + Side2 + Side3;
        }
    }
}

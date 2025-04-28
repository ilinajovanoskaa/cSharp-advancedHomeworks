using Homework02.App.Abstractions;
using Homework02.App.Class;
using Homework02.App.Interfaces;

namespace Homework02.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            ISearchable document = new Document("This is a sample document.");
            ISearchable webPage = new WebPage("This is a webpage with keywords.");
            Console.WriteLine("WebPage search result: " + webPage.Search("keywords"));
            Console.WriteLine("Document search result: " + document.Search("sample"));

            // TASK 2
            IShape rectangle = new Rectangle(5, 10);
            IShape circle = new Circle(7);
            IShape triangle = new Triangle(6, 8);

            Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
            Console.WriteLine("Circle Area: " + circle.GetArea());
            Console.WriteLine("Triangle Area: " + triangle.GetArea());

            // TASK 3
            Shape circleSub = new CircleSub(5);
            Shape triangleSub = new TriangleSub(3, 4, 5);

            Console.WriteLine("Circle Area: " + circleSub.CalculateArea());
            Console.WriteLine("Circle Perimeter: " + circleSub.CalculatePerimeter());

            Console.WriteLine("Triangle Area: " + triangleSub.CalculateArea());
            Console.WriteLine("Triangle Perimeter: " + triangleSub.CalculatePerimeter());

            // TASK 4
            Employee manager = new Manager("Alice", 5000, 1000);
            Employee programmer = new Programmer("Bob", 50, 160);

            manager.DisplayInfo();
            programmer.DisplayInfo();
        }
    }
}

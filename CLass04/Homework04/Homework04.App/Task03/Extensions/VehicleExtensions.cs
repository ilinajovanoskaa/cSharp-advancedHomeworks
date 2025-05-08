using Homework04.App.Task02.Classes;

namespace Homework04.App.Task03.Extensions
{
    public static class VehicleExtensions
    {
        public static void Drive(this Car car)
        {
            Console.WriteLine("The car is driving");
        }
        public static void Wheelie(this MotorBike motorBike)
        {
            Console.WriteLine("The motorbike is driving in one wheel");
        }
        public static void Sail(this Boat boat)
        {
            Console.WriteLine("The boat is sailing");
        }
        public static void Fly(this Plane plane)
        {
            Console.WriteLine("The airplane is flying");
        }
    }
}

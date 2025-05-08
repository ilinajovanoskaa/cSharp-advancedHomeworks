
using Homework04.App.Task01.Models;
using Homework04.App.Task02.Classes;
using Homework04.App.Task03.Extensions;


// Task 01
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("TASK 01");
Console.ResetColor();

string name = "Ilina";
string lastName = "Jovanovska";

List<string> collection = new List<string>() { "Cars", "Boats", "Airplanes", "Motorbikes" };

PrintInConsole printInConsole = new();
printInConsole.Print(name, lastName);
printInConsole.PrintCollection(collection);

//Task02
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("TASK 02");
Console.ResetColor();

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Plane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

//Task03
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("TASK 03");
Console.ResetColor();

Car car1 = new();
MotorBike motorBike1 = new();
Boat boat1 = new();
Plane plane1 = new();

car1.Drive();
motorBike1.Wheelie();
boat1.Sail();
plane1.Fly();




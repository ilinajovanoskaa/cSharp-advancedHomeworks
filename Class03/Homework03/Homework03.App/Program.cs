//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Homework03.App.Task01;
using Homework03.App.Task02.Classes;

// TASK 01
var  result = UserDatabase.Search("name", "Alice");

foreach (User user in result)
{
    Console.WriteLine($"{user.Id} - {user.Name} - {user.Age}");
}

// TASK 02

Vehicle car = new Car();
Vehicle motorBike = new MotoBike();
Vehicle boat = new Boat();
Vehicle plane = new Plane();

car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();





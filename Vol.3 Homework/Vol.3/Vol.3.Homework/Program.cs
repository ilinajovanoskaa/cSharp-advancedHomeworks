// 1. Select the horsepower of US cars with more than 150 horsepower.
using Vol._3.Homework.Models;

List<double> usPowerfulHP = CarsData.Cars
    .Where(c => c.Origin == "US" && c.HorsePower > 150)
    .Select(c => c.HorsePower)
    .ToList();

// 2. Select the weight of European cars with less than 100 horsepower.
List<double> euroLightHPWeight = CarsData.Cars
    .Where(c => c.Origin == "Europe" && c.HorsePower < 100)
    .Select(c => c.Weight)
    .ToList();

// 3. Select the origin of Japanese cars that weigh less than 2200.
List<string> japaneseLightOrigin = CarsData.Cars
    .Where(c => c.Origin == "Japan" && c.Weight < 2200)
    .Select(c => c.Origin)
    .ToList();

// 4. Select the cylinder count of US cars with exactly 8 cylinders.
List<int> usEightCylinders = CarsData.Cars
    .Where(c => c.Origin == "US" && c.Cylinders == 8)
    .Select(c => c.Cylinders)
    .ToList();

// 5. Select the miles per gallon of cars with more than 25 mpg and acceleration time over 15 seconds.
List<double> efficientAndSlowMpg = CarsData.Cars
    .Where(c => c.MilesPerGalon > 25 && c.AccelerationTime > 15)
    .Select(c => c.MilesPerGalon)
    .ToList();

// 6. Get the acceleration time of the last 4-cylinder car with acceleration time less than 15 seconds.
Car lastFastFour = CarsData.Cars
    .Where(c => c.Cylinders == 4 && c.AccelerationTime < 15)
    .LastOrDefault(); 


// 7. Get the model name of the first car that has 0 horsepower.
Car zeroHpCar = CarsData.Cars
    .FirstOrDefault(c => c.HorsePower == 0);



// 8. Get the weight of the last Japanese car with more than 90 horsepower.
Car lastStrongJap = CarsData.Cars
    .Where(c => c.Origin == "Japan" && c.HorsePower > 90)
    .LastOrDefault();



// 9. Get the horsepower of the first US car that weighs more than 4000 and has fewer than 6 cylinders.
Car firstHeavyLightCyl = CarsData.Cars
    .FirstOrDefault(c => c.Origin == "US" && c.Weight > 4000 && c.Cylinders < 6);



// 10. Get the origin of the last car with acceleration time greater than 20 seconds.
Car lastSlow = CarsData.Cars
    .LastOrDefault(c => c.AccelerationTime > 20);


// See https://aka.ms/new-console-template for more information
using Class06.Homework.Models;

Console.WriteLine("Hello, World!");


// 1. Filter all cars that have origin from Europe.
List<Car> europeanCars = CarsData.Cars
    .Where(car => car.Origin == "Europe")
    .ToList();

// 2. Find all unique cylinder values for cars.
List<int> uniqueCylinders = CarsData.Cars
    .Select(car => car.Cylinders)
    .Distinct()
    .ToList();

// 3. Select all car names with their model names converted to uppercase.
List<string> upperCaseModels = CarsData.Cars
    .Select(car => car.Model.ToUpper())
    .ToList();

// 4. Check if there are any cars with horsepower greater than 300.
bool anyHighHorsepower = CarsData.Cars
    .Any(car => car.HorsePower > 300);

// 5. Find the car with the highest horsepower.
Car highestHorsepowerCar = CarsData.Cars.OrderByDescending(car => car.HorsePower).FirstOrDefault();

// 6. Filter all "Chevrolet" cars and order them by weight in descending order.
List<Car> chevroletCarsByWeight = CarsData.Cars
    .Where(car => car.Model == "Chevrolet")
    .OrderByDescending(car => car.Weight)
    .ToList();

// 7. Find the car with the longest model name.
Car longestModelNameCar = CarsData.Cars
    .OrderByDescending(car => car.Model.Length)
    .FirstOrDefault();

// 8. Group cars by their origin and then order the groups by the number of cars in each group (ascending).
var groupedByOrigin = CarsData.Cars
    .GroupBy(car => car.Origin)
    .OrderBy(car => car.Count());

// 9. Find the first 5 cars with the highest horsepower.
List<Car> top5HorsepowerCars = CarsData.Cars
    .OrderByDescending(car => car.HorsePower)
    .Take(5)
    .ToList();

// 10. Find the car with the highest acceleration time.
Car highestAccelerationCar = CarsData.Cars
    .OrderByDescending(car => car.AccelerationTime)
    .FirstOrDefault();

// 11. Select only the model and horsepower of cars with horsepower greater than 200.
var modelHorsepower = CarsData.Cars
    .Where(car => car.HorsePower > 200)
    .Select(car => new { car.Model, car.HorsePower });
    

// 12. Select all unique origins of cars, ordered alphabetically.
List<string> uniqueOrigins = CarsData.Cars
    .Select(car => car.Origin)
    .Distinct()
    .OrderBy(origin => origin)
    .ToList();

// 13. Select all cars with more than 4 cylinders, ordered by origin then horsepower.
List<Car> sortedCylCars = CarsData.Cars
    .Where(car => car.Cylinders > 4)
    .OrderBy(car => car.Origin)
    .ThenBy(car => car.HorsePower)
    .ToList();

// 14. Combine: More than 6 cylinders, then 4 cylinders with HorsePower > 110.
List<Car> filteredCars = CarsData.Cars
    .Where(car => car.Cylinders > 6)
    .Concat(CarsData.Cars.Where(car => car.Cylinders == 4 && car.HorsePower > 110))
    .ToList();

// 15. Cars with >200 HP: lowest, highest, average MPG.
List<Car> powerfulCars = CarsData.Cars
    .Where(car => car.HorsePower > 200 && car.MilesPerGalon > 0)
    .ToList();
double minMpg = powerfulCars
    .Min(car => car.MilesPerGalon);
double maxMpg = powerfulCars
    .Max(car => car.MilesPerGalon);
double avgMpg = powerfulCars
    .Average(car => car.MilesPerGalon);

// 16. Custom: Get top 3 lightweight European cars with HP > 100 and sorted by acceleration
List<Car> customQuery = CarsData.Cars
    .Where(car => car.Origin == "Europe" && car.HorsePower > 100)
    .OrderBy(car => car.Weight)
    .ThenBy(car => car.AccelerationTime)
    .Take(3)
    .ToList();
// 17. Custom: Find all Japanese cars with more than 4 cylinders, sort them by horsepower descending, and project a new object containing the model name in uppercase, horsepower, and weight.
var japaneseCars = CarsData.Cars
    .Where(car => car.Origin == "Japan" && car.Cylinders > 4)
    .OrderByDescending(car => car.HorsePower)
    .Select(car => new { Model = car.Model.ToUpper(), car.HorsePower, car.Weight });
    


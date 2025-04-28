namespace Homework02.App.Class
{
    public abstract class Employee
    {
        public string Name { get; set; } = string.Empty;

        public Employee(string name)
        {
            Name = name;
        }
        public abstract double CalculateSalary();
        public abstract void DisplayInfo();
    }
}

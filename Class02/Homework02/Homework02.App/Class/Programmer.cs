namespace Homework02.App.Class
{
    public class Programmer : Employee
    {
        public Programmer(string name,double hourlyRate, int hoursWorked) : base(name)
        {
            HourlyRate=hourlyRate;
            HoursWorked=hoursWorked;
        }

        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public override double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer: {Name}, Salary: {CalculateSalary()}");
        }
    }
}

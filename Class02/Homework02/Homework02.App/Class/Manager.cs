namespace Homework02.App.Class
{
    public class Manager : Employee
    {
        public Manager(string name,double baseSalary, double bonus) : base(name)
        {
            BaseSalary=baseSalary;
            Bonus=bonus;
        }

        public double BaseSalary { get; set; }
        public double Bonus { get; set; }

        public override double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {Name}, Salary: {CalculateSalary()}");
        }
    }
}

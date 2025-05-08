namespace Homework04.App.Task01.Models
{
    public class PrintInConsole
    {
        
        public void Print<T>(T name, T lastName)
        {
            Console.WriteLine($"{name} {lastName}");
        }

        public void PrintCollection<T>(List<T> collection)
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

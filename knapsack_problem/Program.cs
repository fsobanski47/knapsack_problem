namespace Knapsack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 1) return;

            Console.WriteLine("Enter the seed: ");
            int seed = int.Parse(Console.ReadLine());

            Problem problem = new(number, seed);
            Console.WriteLine(problem.ToString());

            Console.WriteLine("Enter the capacity: ");
            int capacity = int.Parse(Console.ReadLine());
            if (capacity < 1) return;

            Result result = problem.Solve(capacity);
            Console.WriteLine(result.ToString());
        }
    }
}

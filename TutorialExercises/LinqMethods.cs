using System.Linq;

namespace SDV601_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create dataset
            int[] numbers = { 1, 1, 2, 3, 3, 4, 5, 6 };

            // Calculate and declare variables
            var max = numbers.Max();
            var min = numbers.Min();
            var average = numbers.Average();
            var sum = numbers.Sum();
            var distinct = numbers.Distinct();


            // Display
            Console.WriteLine($"Dataset: { string.Join(", ", numbers) }.\n");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Distinct: {string.Join(", ", distinct)}");
        }
    }
}
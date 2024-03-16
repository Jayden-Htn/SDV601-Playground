namespace SDV601_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This will sum a numbers up to n.\n");

            // Get phrase input
            Console.Write("N = ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i<=n; i++)
            {
                sum += i;
                // Console.WriteLine($"Loop: {sum}");
            }

            Console.WriteLine($"Sum is {sum}");
        }
    }
}
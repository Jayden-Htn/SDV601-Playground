namespace SDV601_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your shopping details as prompted (no '$').\n");

            // Set arrays for user input
            var questions = new[] { "Price with GST: ", "GST amount: ", "Price excluding GST: " };
            List<double> valuesList = new List<double>();

            // Get inputs
            foreach ( var question in questions )
            {
                Console.Write(question);
                string userInput = Console.ReadLine();
                valuesList.Add(Convert.ToDouble(userInput)); // Converting to double allows for formatting
            }

            // Declare variables and format
            string price = valuesList[0].ToString("0.00"); ;
            string gstAmount = valuesList[1].ToString("0.00"); ;
            string priceNoGst = valuesList[2].ToString("0.00"); ;

            // Display values
            Console.WriteLine($"Price with GST: ${price}");
            Console.WriteLine($"Price with GST: ${gstAmount}");
            Console.WriteLine($"Price without GST: ${priceNoGst}");
        }
    }
}
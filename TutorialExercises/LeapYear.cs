namespace SDV601_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checking if a year is a leap year!\n");

            // Get year input
            Console.Write("Year to check: ");
            int year = Convert.ToInt16(Console.ReadLine());

            // Automatic current year input
            // int year = DateTime.Now.Year;
            // Console.WriteLine($"This year is {year}");

            // Make century check
            bool isCentury = year % 100 == 0;
            bool isCenturyLeapYear = isCentury ? (Convert.ToBoolean(year % 400 == 0) ? true : false) : true;

            // Console.WriteLine($"Is century: {isCentury}");
            // Console.WriteLine($"Bool check: {Convert.ToBoolean(year % 400 == 0)}");
            // Console.WriteLine($"Is century leap year: {isCenturyLeapYear}");

            Console.WriteLine(year % 4 == 0 && isCenturyLeapYear ? "Leap year" : "Standard year");
        }
    }
}
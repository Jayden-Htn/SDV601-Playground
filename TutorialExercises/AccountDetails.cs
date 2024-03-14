using System;
using System.Text.RegularExpressions;

namespace SDV601_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your account details as prompted below.\n");

            // Set arrays for user input
            var questions = new[] { "Full name: ", "Date of birth: ", "Phone number: ", "Street address: ", "City: ", "Postal code: " };
            List<string> valuesList = new List<string>();

            // Get inputs
            foreach ( var question in questions )
            {
                Console.Write(question);
                string userInput = Console.ReadLine();
                valuesList.Add(userInput);
            }

            // Declare variables
            string name = valuesList[0];
            DateOnly dob = Parse(valuesList[1]);
            string phoneNumber = valuesList[2]; // Use string to maintain leading zeros
            string formattedPhoneNumber = Regex.Replace(phoneNumber, @"(\d{3})(\d{4})(\d{4})", "$1 $2 $3");
            string address = valuesList[3];
            string city = valuesList[4];
            string postalCode = valuesList[5];

            var dateNow = DateOnly.FromDateTime(DateTime.Now);
            // Or Datetime.UtcNow for utc not local time
            double balance = 26254.97;
            
            // Calculate age
            var age = dateNow.Year - dob.Year;

            if (dateNow.DayOfYear < dob.DayOfYear)
            {
                age = age - 1;
            }

            string output =
            $@"<=== Account details ===>
            Name: {name}
            Dob: {dob}
            Age: {age}
            Phone number: {formattedPhoneNumber}
            Address: {address}
            City: {city}
            PostalCode: {postalCode}
            Balance: ${balance}
            ";
            Console.WriteLine();
            Console.WriteLine(output);
            // $@: Interpolated verbatim string
            // (multi-line string with variables inserted)
        }


        public static DateOnly Parse(string userInputDob)
        {
            DateOnly parsedDate = DateOnly.Parse(userInputDob);
            return parsedDate;
        }
    }
}
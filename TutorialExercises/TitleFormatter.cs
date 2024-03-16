namespace SDV601_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase and a space will be added before each capital letter.");

            // Get phrase input
            Console.Write("Phrase to format: ");
            string phrase = Console.ReadLine();

            string response = ToTitleSpaceCase(phrase);

            Console.WriteLine(response);


            static string ToTitleSpaceCase(string phrase)
            {
                // Check each letter in phrase
                string formattedPhrase = "";
                foreach (char letter in phrase)
                {
                    if (char.IsUpper(letter))
                    {
                        formattedPhrase += " " + letter;
                    }
                    else
                    {
                        formattedPhrase += letter;
                    }
                }
                // Check if space at start
                if (formattedPhrase[0] == Convert.ToChar(" ")) ;
                {
                    formattedPhrase = formattedPhrase.Substring(1); // Makes a new string from index 1
                }
                return formattedPhrase;
            }
        }
    }
}
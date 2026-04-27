using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement: First line of the program
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());

            // Check if weight exceeds the limit
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                // End program if weight is too high
                return;
            }

            // Prompt user for package dimensions
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            float length = float.Parse(Console.ReadLine());

            // Requirement: Check if dimensions total is greater than 50
            if ((width + height + length) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                // End program if dimensions are too big
                return;
            }

            // Calculation: (Width * Height * Length * Weight) / 100
            float product = width * height * length * weight;
            float quote = product / 100;

            // Display the quote formatted as a dollar amount
            // The "C2" format string ensures two decimal places and a currency symbol
            Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C2"));
            Console.WriteLine("Thank you!");

            // Keep the console window open
            Console.ReadLine();
        }
    }
}

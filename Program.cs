using System;


// a namespace is a container for classes and functions
namespace NumberGuesser
{
    // Main Class
    internal class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Weston Woodard";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            // Init correct number
            //int correctNumber = 7;

            Random random = new Random();

            // generates random number between one and ten
            int correctNumber = random.Next(1, 10);

            // Init guess var
            int guess = 0;

            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // while loop
            while(guess != correctNumber)
            {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter an actual number");
                    Console.ResetColor();

                    continue;
                }

                // converts input to integer
                guess = Int32.Parse(input);

                if (guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, please try again");
                    Console.ResetColor();
                }
            }
            // Output success message
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Congratulations! You guessed the number correctly!");
            Console.ResetColor();
        }
    }
}

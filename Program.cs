using System;

// Namespaces
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        // static refers to function itself no need to instantiate
        // void -> i.e. no returned data
        static void Main(string[] args)
        {
            // app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Gino Joseph";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            // Write app info to console
            Console.WriteLine("{0}: Version {1} By {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

            // Ask user name
            Console.WriteLine("What is your name?");
            // Get user input
            string inputName = Console.ReadLine();
            // Write user name
            Console.WriteLine("Hello {0}, let's play a game.", inputName);

            // Create a new Random object
            Random random = new Random();
            int correctNumber = random.Next(1, 11);

            // init guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");
            while(guess != correctNumber)
            {
                // Get user guess input
                string input = Console.ReadLine();

                // make sure we're only accepting integers
                if(!int.TryParse(input, out guess))
                {
                    // Change text color error
                    Console.ForegroundColor = ConsoleColor.Red;
                    // Write error msg
                    Console.WriteLine("Please enter an actual number");
                    Console.ResetColor();

                    // keep going
                    continue;
                }


                // cast to int and put into guess
                guess = Int32.Parse(input);

                

                // match guess to correct number
                if(guess != correctNumber)
                {
                    // Change text color error
                    Console.ForegroundColor = ConsoleColor.Red;
                    // Write error msg
                    Console.WriteLine("Wrong Number, please try again");
                    Console.ResetColor();
                }
            }

            // output success message
            Console.ForegroundColor = ConsoleColor.Yellow;
            // Write error msg
            Console.WriteLine("You are CORRECT");
            Console.ResetColor();
        }
    }
}

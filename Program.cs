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
            
            GetAppInfo(); // Run get app info

            GreetUser(); // Ask user name and greet


            while (true)
            {


                // Create a new Random object
                Random random = new Random();
                int correctNumber = random.Next(1, 11);

                // init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {
                    // Get user guess input
                    string input = Console.ReadLine();

                    // make sure we're only accepting integers
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColourMessage(ConsoleColor.Red, "Please enter an actual number");
                        continue;
                    }

                    // cast to int and put into guess
                    guess = Int32.Parse(input);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColourMessage(ConsoleColor.Red, "Wrong Number, please try again");
                    }
                }

                PrintColourMessage(ConsoleColor.Yellow, "You are CORRECT");

                // Ask to play agin
                Console.WriteLine("Play again? [Y or N]");
                // Get answer
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Gino Joseph";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} By {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        // Ask user name and Greet user
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game.", inputName);
        }

        static void PrintColourMessage(ConsoleColor color, string message)
        {
            // Change text color error
            Console.ForegroundColor = color;
            // Write error msg
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            // Generate random magic number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("Welcome to Guess My Number!");

            // Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Need a Higher number");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Need a Lower number");
                }
                else
                {
                    Console.WriteLine($"You guessed it! The magic number was {magicNumber}.");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }
        
            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
             Console.WriteLine();    
        }
        
        Console.WriteLine("Thank you for playing! Goodbye.");
    }
}


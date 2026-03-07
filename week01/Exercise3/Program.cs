using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Guess My Number Game!");

        // Create random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0;

        // Loop until the user guesses correctly
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine("You guessed it!");
    }
}
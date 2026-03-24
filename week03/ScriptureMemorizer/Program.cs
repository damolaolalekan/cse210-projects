using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // 1. Program uses a library of scriptures instead of just one
        // 2. Scripture is selected randomly each time the program runs

        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"),

            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"),

            new Scripture(new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want")
        };

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }

            Console.Write("\nPress Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            // EXCEEDING REQUIREMENTS:
            // This version avoids hiding words that are already hidden
            scripture.HideRandomWords(3);
        }
    }
}
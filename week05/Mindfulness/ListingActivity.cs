using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who have you helped recently?",
        "What made you happy this week?"
    };

    public ListingActivity()
        : base("Listing", "List positive things in your life.") { }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);

        Console.WriteLine("\nStart listing...");
        ShowCountdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        EndMessage();
    }
}
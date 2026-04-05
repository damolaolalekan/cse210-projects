using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time when you stood up for someone."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was it meaningful?",
        "What did you learn?",
        "How did you feel?",
        "What made it special?",
        "How can you apply this again?"
    };

    public ReflectionActivity()
        : base("Reflection", "Reflect on times you showed strength.") { }

    public void Run()
    {
        StartMessage();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("Reflect on this...");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(4);
        }

        EndMessage();
    }
}
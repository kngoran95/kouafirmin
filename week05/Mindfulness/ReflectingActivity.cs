using System;
using System.Collections.Generic;


public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?"
    };


    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times when you demonstrated your strength and resilience.")
    {
    }


    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();

        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"{prompt}");

        Console.WriteLine();


        Console.WriteLine("When you are ready, press enter to continue.");
        Console.ReadLine();


        Console.WriteLine("Now consider the following questions: ");

        ShowSpinner(3);


        DateTime endTime = DateTime.Now.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            string question = _questions[random.Next(_questions.Count)];

            Console.WriteLine($"> {question}");

            ShowSpinner(5);
        }

        Console.WriteLine();


        DisplayEndingMessage();
    }
}
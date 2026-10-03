using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing as many items as possible.")
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


        Console.WriteLine("You can start in: ");

        ShowCountdown(5);
        Console.WriteLine();

        int count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(_duration);


        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            count++;
        }


        Console.WriteLine($"You listed {count} items.");


        DisplayEndingMessage();
    }

}
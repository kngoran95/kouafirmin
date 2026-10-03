using System;
using System.Threading;



public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How many seconds do you wish to practice this activity? ");
        
        int duration;

        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)

        {
            Console.Write("Please enter a valid number: ");
        }

        _duration = duration;

        Console.WriteLine();
        Console.WriteLine("Get ready to start the activity...");

        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done ! you have done a great job !");

        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");

        ShowSpinner(5);
    }


    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console .Write("\b \b");

            i++;
            if (i >= spinner.Length)
            i = 0;
        }
    }


    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
using System;


public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by breathing slowly, inhaling and exhaling deeply. Clear your mind and focus on your breathing.")
    {
    }


    public void Run()
    {
        DisplayStartingMessage();

        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(4);
            elapsedTime += 4;

            if (elapsedTime >= _duration)
            break;

            Console.Write("Breathe out... ");
            ShowCountdown(4);
            elapsedTime += 4;

            Console.WriteLine();
        }
        

        DisplayEndingMessage();
    }
}
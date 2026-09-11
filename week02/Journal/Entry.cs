using System;


public class Entry
{

    //Save other information in the journal entry.
    // I added two entries to check on the mood and the weather.
    public string _mood;
    public string _weather;

    public string _date;
    public string _promptText;
    public string _entryText;
    

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Weather: {_weather}");
    }

    public string ToFileFormat()
    {
        return ($"{_date}|{_promptText}|{_entryText}|{_mood}|{_weather}");
    }

}
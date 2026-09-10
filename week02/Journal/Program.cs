using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");



        Journal theJournal = new Journal();

        PromptGenerator thePromptGenerator = new PromptGenerator();

        int choice = 0;

        while (choice != 5)
        {
            
        }
        Entry anEntry = new Entry();
        anEntry.Display();
    }
}
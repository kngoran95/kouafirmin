using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");



        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();
    }
}
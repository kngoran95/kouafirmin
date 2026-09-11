using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

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
            Console.WriteLine("personal journal");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit");

            choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                string prompt = thePromptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);

            

                Console.Write("Mood: ");
                string mood = Console.ReadLine();

                Console.Write("Weather: ");
                string weather = Console.ReadLine();

                Console.Write("Response: ");
                string response = Console.ReadLine();


                Entry theEntry = new Entry();
                theEntry._date = DateTime.Now.ToShortDateString();
                theEntry._promptText = prompt;
                theEntry._entryText = response;
                theEntry._mood = mood;
                theEntry._weather = weather;


                theJournal.AddEntry(theEntry);

                break;
                

                case 2:

                Console.WriteLine();
                theJournal.DisplayAll();
                break;


                case 3:

                Console.Write("Name of file: ");
                string saveFile = Console.ReadLine();

                theJournal.SaveToFile(saveFile);
                Console.WriteLine("Save the journal.");
                break;


                case 4:

                Console.Write("Name of file: ");
                string fileName = Console.ReadLine();

                theJournal.LoadFromFile(fileName);
                Console.WriteLine("Load journal.");
                break;


                case 5:

                Console.WriteLine("Good Bye!");
                break;


            }
        }
        Entry anEntry = new Entry();
        anEntry.Display();
    }
}
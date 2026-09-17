using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Console.WriteLine();


        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever belives in him shall not perish but have eternal life. "),

            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding in all your ways acknowledge him, and he will make straight your paths."),

            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through him who strengthens me.")
        };

// The user can choose to add their favorite scripture themselves by entering the reference and the text of the scripture.

        Console.WriteLine("Choose a scripture: ");
        Console.WriteLine("1. John 3:16");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("3. Philippians 4:13");
        Console.WriteLine("4. Add your own favorite writing: ");
        Console.Write("Your choice: ");



        string choice = Console.ReadLine();


        Scripture selectedScripture;

        if (choice == "4")
        {
            Console.Write("Book: ");
            string book = Console.ReadLine();


            Console.Write("Chapter: ");
            int chapter = int.Parse(Console.ReadLine());


            Console.Write("Start Verse: ");
            int startVerse = int.Parse(Console.ReadLine());


            Console.Write("End Verse (0 if one only verse): ");

            int endVerse = int.Parse(Console.ReadLine());


            Console.Write("scripture text: ");
            string text = Console.ReadLine();


            Reference reference;


            if (endVerse == 0)
            {
                reference = new Reference(book, chapter, startVerse);
            }

            else
            {
                reference = new Reference(book, chapter, startVerse, endVerse);
            }


            selectedScripture = new Scripture(reference, text);
        }


        else
        {
            Console.Write("Select a scripture (1 - 3): ");
            int index = int.Parse(Console.ReadLine());

            selectedScripture = scriptures[index - 1];
        }


        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();


            Console.Write("Press 'Enter' to continue or type 'quit': ");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                return;
            }


            selectedScripture.HideRandomWords(3);
        }


        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("All writings are hidden.");
    }
        

}


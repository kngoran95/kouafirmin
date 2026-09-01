using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();


        Console.Write("what is your magic number? ");
        int magicNumber = int.Parse(Console.ReadLine());


        Random randomGenerator = new Random();

        int magicNumberGenerated = randomGenerator.Next(1, 100);

        int userGuess = -1;

        while (userGuess != magicNumberGenerated)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Heigher");
            }

            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();



        bool running = true;


        while (running)
        {
            Console.WriteLine("Mindfulness program menu:");
            Console.WriteLine();

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();


            Console.Write("Select an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;


                case "2":

                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;


                case "3":

                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;


                case "4":

                    running = false;
                    break;

                default:

                    Console.WriteLine("Invalid option. Please select a valid option (1-4): ");
                    break;
            }


            if (running)
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to return to the main menu.");

                Console.ReadLine();
            }
        }
    }
}
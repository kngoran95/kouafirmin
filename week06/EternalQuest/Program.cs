using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Console.WriteLine();

        GoalManager manager = new GoalManager();
        int choice = 0;

        while (choice != 6)
        {
            manager.DisplayPlayerInfo();

            Console.WriteLine("Menu: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");

            choice = int.Parse(Console.ReadLine() ?? "0");

            switch (choice)
            {
                case 1:

                manager.CreateGoal();
                break;

                case 2:

                manager.ListGoals();
                break;

                case 3:
                manager.SaveGoals();
                break;

                case 4:
                manager.LoadGoals();
                break;

                case 5:
                manager.RecordEvent();
                break;

                case 6:
                Console.WriteLine("Goodbye!");
                break;

                default:
                Console.WriteLine("Invalid choice.");
                break;
            }

            Console.WriteLine();
        }
    }
}
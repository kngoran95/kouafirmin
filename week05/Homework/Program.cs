using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Console.WriteLine();


        Assignement assignement1 = new Assignement("Sammuel Bennett", "multiplication");

        Console.WriteLine(assignement1.GetSummary());
        Console.WriteLine();


        MathAssignement assignement2 = new MathAssignement("Roberto Rodriguez", "Fraction", "7.3", "8-19");


        Console.WriteLine(assignement2.GetSummary());
        Console.WriteLine(assignement2.GetHomeworkList());
        Console.WriteLine();




        WritingAssignement assignement3 = new WritingAssignement("Mary Waters", "European History", "The cause of World War II ");

        Console.WriteLine(assignement3.GetSummary());
        Console.WriteLine(assignement3.GetWritingInformation());
        Console.WriteLine();
        

    }
}
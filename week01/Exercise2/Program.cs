using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine();



        //Ask the user for the grade
        Console.Write("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);


        //Figure out the letter grade
        string LetterGrade = "";

        if (gradePercentage >= 90)
        {
            LetterGrade = "A";
        
        }

        else if (gradePercentage >= 80)
        {
            LetterGrade = "B";
        }

        else if (gradePercentage >= 70)
        {
            LetterGrade = "C";
        }

        else if (gradePercentage >= 60)
        {
            LetterGrade = "D";
        }

        else
        {
            LetterGrade = "F";
        }


        //get the last digit
        int LastDigit = gradePercentage % 10;

        //determine the sign
        string sign = "";

        if (LastDigit >= 7)
        {
            sign = "+";
        }
        else if (LastDigit <= 3)
        {
            sign = "-";
        }

        else
        {
            sign = "";
        }

        //Handle exceptions (A+, F+, F-)
        if (LetterGrade == "A" && sign == "+")
        {
            sign = "";
        }

        //Display the letter grade
        Console.WriteLine($"Your Letter Grade is: {LetterGrade}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");

        }

        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better Luck next time!");
        }





    }
}
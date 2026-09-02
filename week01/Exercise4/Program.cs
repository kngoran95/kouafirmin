using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine();




        List<int> numbers = new List<int>();

        int userNumber = -1;

        Console.Write("Enter a list of numbers, type 0 when finished.");
        Console.WriteLine();


        while (userNumber !=0)
        {
            Console.Write("Enter a number: ");
            string userResponse = Console.ReadLine();

            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }

        }

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.Write($"The sum is: {sum}");

        Console.WriteLine();

        if (numbers.Count > 0)
        {
            float average = (float)sum / numbers.Count;
            Console.Write($"The average is: {average}");
        }

        Console.WriteLine();

       int max = numbers[0];

       foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.Write($"The largest number is: {max}");

        Console.WriteLine();


        //Have the user enter both positive and negative numbers, then find the smallest positive number.
        int smallestPositive = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        Console.Write($"The smallest positive number is: {smallestPositive}");

        Console.WriteLine();


        //Sort the numbers in the list and display the sorted list.
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number + "");
        }

    }
}
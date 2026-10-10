using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;



public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;


    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }


    public void CreateGoal()
    {
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Choose a goal type: ");
        int choice = int.Parse(Console.ReadLine() ?? "0");
    
        Console.Write("Name: ");
        string name = Console.ReadLine();
        
        Console.Write("Description: ");
        string description = Console.ReadLine();
    
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine() ?? "0");

        switch (choice)
        {
        
            case 1:
            
            _goals.Add(new SimpleGoal(name, description, points));
            break;
        
            case 2:
            
            _goals.Add(new EternalGoal(name, description, points));
            break;
            
            case 3:
            
            Console.Write("Target amount: ");
            int target = int.Parse(Console.ReadLine() ?? "0");
            
            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine() ?? "0");
            
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
            break;
        }
    }
    
    public void ListGoals()
    {
       if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Goals: ");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        ListGoals();

        Console.Write("Which goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine() ?? "0");

        int points = _goals[goalNumber - 1].RecordEvent();

        _score += points;

        Console.WriteLine($"Congratulation! You earned {points} points!");
        Console.WriteLine($"Total score: {_score}");
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string fileName = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(fileName))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string fileName = Console.ReadLine() ?? "";

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }

            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }

            else if (type == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]), int.Parse(parts[6])));
            }
        }

        Console.WriteLine("Goals loaded successfully.");
    }
}
using System;


public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }


    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed) : base(name, description, points)
    {
        _target = target;

        _bonus = bonus;

        _amountCompleted = completed;

    }


    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            
            if (_amountCompleted == _target)
            {
                return GetPoints() + _bonus;
            }

            return GetPoints();
        }

        return 0;
    }


    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }


    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {GetName()} ({GetDescription()}) Completed {_amountCompleted}/{_target} times";
    }


    public override string GetSaveString()
    {
        return $"CheicklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_target}|{_amountCompleted}";
    }
}
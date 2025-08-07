public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    private int _target;
    public int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You have earned {_points + _bonus}");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points}");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "100%" : "[]";
        return $"{status} {_goalName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_goalName}|{_description}|{_points}|{_target}|{_amountCompleted}|{_bonus}";
    }
}
using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected internal int _points;

    public Goal(string name, string description, int points)
    {
        _goalName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[]";
        return $"{status} {_goalName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}
public class SwimmingActivity : Activity
{
    private int _numberOfLaps;

    public SwimmingActivity(int time, int laps) : base(time)
    {
        _numberOfLaps = laps;
    }

    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000.0;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _timeInMinutes) * 60.0;
    }

    public override double GetPace()
    {
        return _timeInMinutes / GetDistance();
    }
}
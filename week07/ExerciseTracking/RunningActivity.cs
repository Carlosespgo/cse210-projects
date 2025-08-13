public class RunningActivity : Activity
{
    private float _distance;
    public RunningActivity(int time, float distance) : base(time)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / _timeInMinutes) * 60;
    }

    public override double GetPace()
    {
        return _timeInMinutes / _distance;
    }
}
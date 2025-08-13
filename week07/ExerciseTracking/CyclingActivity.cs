public class CyclingActivity : Activity
{
    private int _speed;

    public CyclingActivity(int time, int speed) : base(time)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _timeInMinutes) / 60.0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60.0 / _speed;
    }

}
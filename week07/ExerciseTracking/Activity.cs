public abstract class Activity
{
    protected DateTime _date;
    protected int _timeInMinutes;

    public Activity(int time)
    {
        _date = DateTime.Now;
        _timeInMinutes = time;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_timeInMinutes} min): Distance {GetDistance(): 0.0} km, Speed {GetSpeed(): 0.0} kph, Pace {GetPace(): 0.0} min per km";
    }

}
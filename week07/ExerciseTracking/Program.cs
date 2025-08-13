using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        RunningActivity activity1 = new RunningActivity(60, 10);
        _activities.Add(activity1);

        CyclingActivity activity2 = new CyclingActivity(90, 50);
        _activities.Add(activity2);

        SwimmingActivity activity3 = new SwimmingActivity(30, 6);
        _activities.Add(activity3);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
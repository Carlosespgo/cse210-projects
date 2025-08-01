public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 0;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(6);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int countdown = 0;
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            countdown += 3;
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(countdown);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(countdown);
        }
        Console.WriteLine(2);
        DisplayEndingMessage();
    }
}
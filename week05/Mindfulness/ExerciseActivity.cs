public class ExerciseActivity : Activity
{
    List<string> _exercises = new List<string>();
    public ExerciseActivity()
    {
        _name = "Exercise Acitivy";
        _description = "This activity will help you to do some quick exercise to release all the stress, through a few seconds of a random exercise without stopping, don't forget to warm up before!\n(Duration 30s at least)";
        _duration = 0;
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(6);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine(GetRandomExercise());
        Console.WriteLine();
        Console.WriteLine("Let's gonna start!...");
        ShowCountDown(5);
        while (DateTime.Now < endTime)
        {
            DisplayExercise();
        }
        Console.WriteLine();
        DisplayEndingMessage();
    }

    public string GetRandomExercise()
    {
        _exercises.Add("Squat");
        _exercises.Add("Sit-up");
        _exercises.Add("Plank");
        _exercises.Add("Burpees");
        _exercises.Add("Push-ups");
        Random random = new Random();
        int i = random.Next(_exercises.Count());
        return $"¡¡{_exercises[i]}!! ";
    }

    public void DisplayExercise()
    {
        Console.WriteLine();
        Console.WriteLine("Now!!!");
        ShowSpinner(15);
        Console.WriteLine("Dont stop! You can do it!");
        ShowSpinner(15);
        Console.WriteLine("Its all!");
    }
}
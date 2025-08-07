using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _goals.Clear();
        _score = 0;
    }

    public void Start()
    {
        //This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop.
        string actSelected;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            actSelected = Console.ReadLine();
            if (actSelected == "1")
            {
                CreateGoal();
            }
            else if (actSelected == "2")
            {
                ListGoalNames();
            }
            else if (actSelected == "3")
            {
                SaveGoals();
            }
            else if (actSelected == "4")
            {
                LoadGoals();
            }
            else if (actSelected == "5")
            {
                RecordEvent();
            }
        } while (actSelected != "6");
    }
    public void DisplayPlayerInfo()
    {
        // Displays the players current score.
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        //Lists the names of each of the goals.
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        }
    }
    public void ListGoalDetails()
    {
        //Lists the details of each goal (including the checkbox of whether it is complete).
        foreach (Goal goal in _goals)
        {
            goal.GetStringRepresentation();
        }
    }
    public void CreateGoal()
    {
        //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
        Console.Clear();
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Wich type of Goal would you like to create?: ");
        string TypeGoal = Console.ReadLine();
        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());
        if (TypeGoal == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (TypeGoal == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (TypeGoal == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times?: ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
    }
    public void RecordEvent()
    {
        // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
        Console.Clear();
        Console.WriteLine("The goals are: ");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int record = int.Parse(Console.ReadLine());
        Goal selectedGoal = _goals[record - 1];
        selectedGoal.RecordEvent();
        Console.WriteLine("Updated goal!");
        if (selectedGoal is SimpleGoal)
        {
            _score += ((SimpleGoal)selectedGoal)._points;
        }
        else if (selectedGoal is EternalGoal)
        {
            _score += ((EternalGoal)selectedGoal)._points;
        }
        else if (selectedGoal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete())
                _score += checklist._points + checklist._bonus;
            else
                _score += checklist._points;
        }      
    }
    public void SaveGoals()
    {
        // Saves the list of goals to a file.
        Console.Clear();
        Console.Write("What is the filename for the goal file?: ");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }
    public void LoadGoals()
    {
        //Loads the list of goals from a file.
        Console.Clear();
        Console.Write("Enter the filename to load goals from: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _goals.Clear();
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length < 4)
                {
                    Console.WriteLine($"Invalid line format: {line}");
                    continue;
                }
                string type = parts[0];
                if (type == "SimpleGoal")
                {
                    if (parts.Length < 5) continue;
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    if (isComplete) goal.RecordEvent();
                    _goals.Add(goal);
                }
                else if (type == "EternalGoal")
                {
                    if (parts.Length < 4) continue;
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }
                else if (type == "ChecklistGoal")
                {
                    if (parts.Length < 7) continue;
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int completed = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int i = 0; i < completed; i++)
                    {
                        goal.RecordEvent();
                    }
                    _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully!");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
        _score = 0; // Reinicia el puntaje

        foreach (Goal goal in _goals)
        {
            if (goal is SimpleGoal simple && simple.IsComplete())
            {
                _score += simple._points;
            }
            else if (goal is EternalGoal)
            {
                // Eternal goals don't contribute to score on load (they're never complete)
            }
            else if (goal is ChecklistGoal checklist)
            {
                _score += checklist._points * checklist._amountCompleted;
                if (checklist.IsComplete())
                {
                    _score += checklist._bonus;
                }
            }
        }

    }
}
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score}");
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("You have no goal yet.");
            return;
        }

        Console.WriteLine("Your Goals: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine();
    }
    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter point value: ");
        int points =
        int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.WriteLine("How many times would you like to complete this goal?");
            int requiredTimes = int.Parse(Console.ReadLine());

            Console.Write("Enter bonus value: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, requiredTimes, bonusPoints));
        }

        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
           Console.WriteLine("You have no goals to record.");
        return; 
        }
        DisplayGoals();
        Console.Write("Which goal did you accomplish? (enter number)");
        int index = int.Parse(Console.ReadLine()) -1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid Selection");
            return;
        }

        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"You earned {pointsEarned} points!");
    }

    public void SaveGoals()
    {
        Console.Write("Enter file name to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Goals successfully saved");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found");
            return;
        }

        _goals.Clear();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(": ", 2);
            string type = parts[0];
            string data = parts[1];

            if (type == "SimpleGoal")
                _goals.Add(SimpleGoal.LoadFromString(data));
            else if (type == "EternalGoal")
                _goals.Add(EternalGoal.LoadFromString(data));
            else if (type == "ChecklistGoal")
                _goals.Add(ChecklistGoal.LoadFromString(data));
        }    

        Console.WriteLine("Goals Loaded Successfully!");
    }

}        
   
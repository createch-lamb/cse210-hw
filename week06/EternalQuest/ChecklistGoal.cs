public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _requiredTimes;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int requiredTimes, int bonusPoints) : base(name, description, points)
    {
        _timesCompleted = 0;
        _requiredTimes = requiredTimes;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("This goal is already completed.");
            return 0;
        }
        _timesCompleted++;

        if (IsComplete())
        {
            Console.WriteLine("Congratualtions on completing this goal!");
            return GetPoints() + _bonusPoints;
        }
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $" {status} {GetName()} - {GetDescription()} (Completed: {_timesCompleted}/{_requiredTimes})";
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _requiredTimes;
    }

    
    public override string GetSaveString()
    {
        return $"ChecklistGoal: {GetName()} | {GetDescription()} | {GetPoints()} | {_timesCompleted} | {_requiredTimes} | {_bonusPoints}";
    }

    public static ChecklistGoal LoadFromString(string data)
    {
        string[] parts = data.Split(" | ");
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        int timesCompleted = int.Parse(parts[3]);
        int requiredTimes = int.Parse(parts[4]);
        int bonusPoints = int.Parse(parts[5]);

        ChecklistGoal goal = new ChecklistGoal(name, description, points, requiredTimes, bonusPoints);
        for (int i = 0; i < timesCompleted; i++)
        {
            goal.RecordEvent();
        }
        return goal;
    }
}
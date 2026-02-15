public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            Console.WriteLine("This goal is already complete!");
            return 0;
        }
        _isComplete = true;
        return GetPoints();
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ?  "[X]"  :  "[ ]";
        return $"{status} {GetName()} - {GetDescription()}";
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetSaveString()
    {
        return $"SimpleGoal: {GetName()} | {GetDescription()} | {GetPoints()} | {_isComplete}";
    }

    public static SimpleGoal LoadFromString(string data)
    {
        string[] parts = data.Split(" | ");
        string name = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        bool isComplete = bool.Parse(parts[3]);

        SimpleGoal goal = new SimpleGoal(name, description, points);
        if (isComplete)
        {
            goal.RecordEvent();
        }
        return goal;
    }
}
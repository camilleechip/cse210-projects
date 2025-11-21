public class ChecklistGoal : Goal
{
    private int _progressNumerator;
    private int _progressDenominator;
    private int _progressPoints;
    public ChecklistGoal(bool completionStatus, int points, string name, string description, int progressDenominator, int progressPoints)
        : base(completionStatus, points, name, description)
    {
        _progressNumerator = 0;
        _progressDenominator = progressDenominator;
        _progressPoints = progressPoints;
    }

    public override void UpdateCompletion()
    {
        if (_progressNumerator < _progressDenominator)
        {
            _progressNumerator++;
            if (_progressNumerator >= _progressDenominator)
            SetCompletionStatus(true);
        }
    }

    public override string PrintProgress()
    {
        string status = GetCompletionStatus() ? "[X]" : "[ ]";
        return $"{status} {GetName()} - {GetDescription()} ({GetPoints()} points) Completed {_progressNumerator}/{_progressDenominator} times";  
    }

    public override void SaveToFile()
    {
        string line = $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{GetCompletionStatus()},{_progressNumerator},{_progressDenominator},{_progressPoints}";
        File.AppendAllText("goals.txt", line + "\n");
    }

    public static List<ChecklistGoal> LoadFromFile()
    {
        string filename = "goals.txt";
        List<ChecklistGoal> goals = new List<ChecklistGoal>();

        if (!File.Exists(filename))
        return goals;

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool completionStatus = bool.Parse(parts[4]);
                int progressNumerator = int.Parse(parts[5]);
                int progressDenominator = int.Parse(parts[6]);
                int progressPoints = int.Parse(parts[7]);

                ChecklistGoal goal = new ChecklistGoal(completionStatus, points, name, description, progressDenominator, progressPoints);
                goal._progressNumerator = progressNumerator;
                goals.Add(goal);

                Goal.AllGoals.Add(goal);
            }
        }
        return goals;
    }

        public override int EarnedPoints()
    {
        int basePoints = GetPoints() * Math.Min(_progressNumerator, _progressDenominator);
        int bonus = GetCompletionStatus() ? _progressPoints : 0;
        return basePoints + bonus;
    }
}
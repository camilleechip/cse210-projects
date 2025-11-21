public class EternalGoal : Goal
{
    public EternalGoal(bool completionStatus, int points, string name, string description)
        : base(completionStatus, points, name, description)
    {    
    }

    public override string PrintProgress()
    {
        return "[ ]";    
    }

    public override void UpdateCompletion()
    {
        SetCompletionStatus(false);
    }

    public override void SaveToFile()
    {
        string line = $"EternalGoal,{GetName()},{GetDescription()},{GetPoints()},{GetCompletionStatus()}";
        File.AppendAllText("goals.txt", line + "\n");
    }

    public static List<EternalGoal> LoadFromFile()
    {
        string filename = "goals.txt";
        List<EternalGoal> goals = new List<EternalGoal>();

        if (!File.Exists(filename))
        return goals;

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool completionStatus = bool.Parse(parts[4]);

                EternalGoal goal = new EternalGoal(completionStatus, points, name, description);
                goals.Add(goal);

                Goal.AllGoals.Add(goal);
            }
        }
        return goals;
    }

        public override int EarnedPoints()
    {
        return GetPoints();
    }
}
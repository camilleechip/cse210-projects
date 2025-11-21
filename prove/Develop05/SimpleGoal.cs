using System;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal(bool completionStatus, int points, string name, string description)
        : base(completionStatus, points, name, description)
    {    
    }

    public override string PrintProgress()
    {
        if (GetCompletionStatus())
        return "[X]";

        else
        return "[ ]";    
    }

    public override void UpdateCompletion()
    {
        SetCompletionStatus(true);
    }
    public override void SaveToFile()
    {
        string line = $"SimpleGoal,{GetName()},{GetDescription()},{GetPoints()},{GetCompletionStatus()}";
        File.AppendAllText("goals.txt", line + "\n");
    }

    public static List<SimpleGoal> LoadFromFile()
    {
        List<SimpleGoal> goals = new List<SimpleGoal>();
        string filename = "goals.txt";

        if (!File.Exists(filename))
        return goals;

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            if (parts[0] == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool completionStatus = bool.Parse(parts[4]);

                SimpleGoal goal  = new SimpleGoal(completionStatus, points, name, description);
                goals.Add(goal);

                Goal.AllGoals.Add(goal);
            }
        }
        return goals;
    }

    public override int EarnedPoints()
    {
        return GetCompletionStatus() ? GetPoints() : 0;
    }
} 
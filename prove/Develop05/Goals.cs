using System.ComponentModel;

public abstract class Goal
{
    private bool _completionStatus;
    private int _points;
    private string _name;
    private string _description;

    public static List<Goal>AllGoals = new List<Goal>();

    public Goal(bool completionStatus, int points, string name, string description)
    {
        _completionStatus = completionStatus;
        _points = points;
        _name = name;
        _description = description;

    }

    public static string GetPlayerLevel()
    {
        int totalPoints = Goal.AllGoals.Sum(g => g.EarnedPoints());
        if (totalPoints < 50) return "Beginner";
        else if (totalPoints < 100) return "Intermediate";
        else return "Legendary";
    }

     public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public bool GetCompletionStatus()
    {
        return _completionStatus;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetCompletionStatus(bool status)
    {
        _completionStatus = status;
    }

    public abstract void UpdateCompletion();
    public abstract void SaveToFile();
    public abstract int EarnedPoints();
    public abstract string PrintProgress();

}
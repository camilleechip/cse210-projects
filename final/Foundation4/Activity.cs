using System.Diagnostics;

public abstract class Activity
{
    private int _length;
    private DateTime _dateTime;
    private string _activityType;

    public Activity(int length, DateTime dateTime, string activityType)
    {
        _length = length;
        _dateTime = dateTime;
        _activityType = activityType;
    }
    
    public int GetLength()
    {
        return _length;
    }

    public DateTime GetDateTime()
    {
        return _dateTime;
    }

    public string GetSummary()
    {
        return  $"{GetDateTime():dd MMM yyyy} {_activityType} ({GetLength()} min)- Distance {GetDistance():F1} miles,\nSpeed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile.";
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
}
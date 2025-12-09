public class Running : Activity
{
    private double _distance;

    public Running(int length, DateTime dateTime, double distance) 
        : base(length, dateTime, "Running")
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;     
    }
    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}
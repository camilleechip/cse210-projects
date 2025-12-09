public class Swimming : Activity
{
    private int _laps;

    public Swimming(int length, DateTime dateTime, int laps) 
        : base(length, dateTime, "Swimming")
    {
        _laps = laps;
    }

     public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0 * 0.62;     
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
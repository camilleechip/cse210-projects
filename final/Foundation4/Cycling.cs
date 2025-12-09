using System.ComponentModel.DataAnnotations;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(int length, DateTime dateTime, double speed) 
        : base(length, dateTime, "Cycling")
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return GetSpeed() * (GetLength() / 60.0);     
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}
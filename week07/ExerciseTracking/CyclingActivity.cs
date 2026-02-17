public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }
    public override string GetActivity()
    {
        return "Cycling";
    }

    public override double GetDistance()
    {
        double distance = _speed * GetMinutes() / 60;
        return Math.Round(distance, 2);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

}
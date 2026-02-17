public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override string GetActivity()
    {
        return "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }
}
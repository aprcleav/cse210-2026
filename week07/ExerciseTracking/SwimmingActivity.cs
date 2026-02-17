public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, int minutes, double laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override string GetActivity()
    {
        return "Swimming";
    }

    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000 * 0.62;
        return Math.Round(distance, 2);
    }

}
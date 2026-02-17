using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();

    public virtual double GetSpeed()
    {
        double speed = GetDistance() / GetMinutes() * 60;
        return Math.Round(speed, 2);
    }
    public double GetPace()
    {
        double pace = 60 / GetSpeed();
        return Math.Round(pace, 2);
    }

    public abstract string GetActivity();

    public virtual void GetSummary()
    {
        Console.WriteLine($"\n{_date} {GetActivity()} ({_minutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min/mile");
    }

    
}
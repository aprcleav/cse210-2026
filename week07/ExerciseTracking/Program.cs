using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();

        RunningActivity r1 = new RunningActivity("10 Feb 2026", 65, 8);
        activities.Add(r1);

        CyclingActivity c1 = new CyclingActivity("12 Feb 2026", 60, 10);
        activities.Add(c1);

        SwimmingActivity s1 = new SwimmingActivity("14 Feb 2026", 60, 58);
        activities.Add(s1);

        foreach (Activity a in activities)
        {
            a.GetSummary();
        }
    }
}
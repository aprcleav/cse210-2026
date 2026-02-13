public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }
    public override void RecordEvent()
    // Tells the user how many points they've earned without setting the goal as complete
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

    public override bool IsComplete()
    // Stays set to false for eternal goals so they don't get checked off
    {
        return false;
    }

    public override string GetStringRepresentation()
    // Provides all of the details of a goal in a way that is easy to save to a file, and then load later.
    {
        return $"Eternal Goal::{GetName()}::{GetDescription()}::{GetPoints()}";
    }
}
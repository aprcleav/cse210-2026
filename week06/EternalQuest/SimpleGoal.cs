public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    
    public void SetComplete(bool complete)
    {
        _isComplete = complete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    // Provides all of the details of a goal in a way that is easy to save to a file, and then load later.
    {
        return $"Simple Goal::{GetName()}::{GetDescription()}::{GetPoints()}::{_isComplete}";
    }
}
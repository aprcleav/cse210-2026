using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public void SetAmountCompleted(int completed)
    {
        _amountCompleted = completed;
    }

    public override void RecordEvent()
    // Records the amount completed and awards bonus points if completed the target number of times. 
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            int points = GetPoints();
            Console.WriteLine($"You got a bonus of {_bonus} points!");
            points += _bonus;
            SetPoints(points);
        }
        else if (_amountCompleted > _target)
        // Keeps user from getting extra bonus points if they try to complete the goal more than the set number of times and encourages them to set a new goal.
        {
            Console.WriteLine("\nYou already completed this goal. Time to set a new one!");
            SetPoints(0);
            _amountCompleted--;
        }

    }

    public override bool IsComplete()
    // Returns true if the user completed the goal the target number of times
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailString()
    // Returns the all the details for the ChecklistGoal class as a string
    {
        if (IsComplete())
        {
            return $"[X] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    // Provides all of the details of a goal in a way that is easy to save to a file, and then load later.
    {
        return $"Checklist Goal::{GetName()}::{GetDescription()}::{GetPoints()}::{_bonus}::{_target}::{_amountCompleted}";
    }
}
using System;
// Showing Creativity: I added code to the ChecklistGoal class's RecordEvent() method that keeps the user from getting continuous bonus points if they complete the goal extra times (for example, 6/5). It displays a message that encourages them to set a new goal and sets the points for that goal back to 0 and keeps the _amountCompleted to whatever the original target was (for example, 5/5).

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}
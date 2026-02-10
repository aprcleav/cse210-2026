public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public void SetName(string name)
    {
        _shortName = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(string points)
    {
        _shortName = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailString()
    // This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description.
    {
        if (!IsComplete())
        {
            return $"[ ] {_shortName} ({_description})";
        }
        else
        {
            return $"[X] {_shortName} ({_description})";
        }
    }
    public abstract string GetStringRepresentation();
}
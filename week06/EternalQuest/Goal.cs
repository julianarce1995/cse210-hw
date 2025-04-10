public abstract class Goal
{
    private String _shortName;
    private String _description;
    private String _points;

    public String GetShortName()
    {
        return _shortName;
    }
    public String GetDescription()
    {
        return _description;
    }
    public String GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points.ToString();
    }

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract Boolean IsComplete();
    public virtual String GetDetailsString()
    {
        return $"[{(IsComplete() ? "x" : " ")}] {_shortName} ({_description})";
    }
    public abstract String GetStringRepresentation();
}
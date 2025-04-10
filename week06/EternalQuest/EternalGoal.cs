public class EternalGoal : Goal
{
    private Boolean _isComplete;
    public EternalGoal(string name, string description, string points) : base(name, description, points) { }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
    }
    public override  Boolean IsComplete()
    {
        return _isComplete;
    }
    public override String GetStringRepresentation()
    {
        return $"EternalGoal: {GetShortName()}, {GetDescription()}, {GetPoints()}, {_isComplete}";
    }
}
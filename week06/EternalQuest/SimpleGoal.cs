public class SimpleGoal : Goal
{
    private Boolean _isComplete;

    public SimpleGoal(string name, string description, string points): base(name,description,points){}
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
    }
    public override Boolean IsComplete()
    {
        return _isComplete;
    }
    public override String GetStringRepresentation()
    {
        return $"SimpleGoal: {GetShortName()}, {GetDescription()}, {GetPoints()}, {_isComplete}";
    }
}
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int target, int bonus, string name, string description, string points) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
    }
    public override  Boolean IsComplete()
    {
        if (_amountCompleted == _target)
        {
            SetPoints(int.Parse(GetPoints())+_bonus);
            return true;
        }
        return false;
    }
    public override String GetDetailsString()
    {
        return $"[{(IsComplete() ? "x" : " ")}] {GetShortName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }
    public override String GetStringRepresentation()
    {
        return $"ChecklistGoal: {GetShortName()}, {GetDescription()}, {GetPoints()}, {_target}, {_bonus}";
    }
}
public class CyclingActivity : BaseActivity
{
    private double _speed;

    public CyclingActivity(int lengthTimeInMinuts, double speed) : base(lengthTimeInMinuts)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (GetLengthTimeInMinutes() / 60.0);
    }

    public override double GetPace()
    {
        double distance = GetDistance();
        return GetLengthTimeInMinutes() / distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}
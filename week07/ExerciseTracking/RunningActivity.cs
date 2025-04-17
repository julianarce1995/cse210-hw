public class RunningActivity : BaseActivity
{
    private double _distance;

    public RunningActivity(int lengthTimeInMinuts, double distance) : base(lengthTimeInMinuts)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return GetLengthTimeInMinutes() / _distance;
    }

    public override double GetSpeed()
    {
        return  60.0 * (_distance / GetLengthTimeInMinutes()) ;
    }
}
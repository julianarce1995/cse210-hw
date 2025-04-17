public class SwimmingActivity : BaseActivity
{
    //Swimming: number of laps
    private int _laps;

    public SwimmingActivity(int lengthTimeInMinuts, int laps) : base(lengthTimeInMinuts)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }

    public override double GetPace()
    {
         return GetLengthTimeInMinutes() / GetDistance();
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetLengthTimeInMinutes() * 60.0;
    }
}
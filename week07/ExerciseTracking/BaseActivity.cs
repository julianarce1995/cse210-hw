using System.Dynamic;

public abstract class BaseActivity
{
    private int _lengthTimeInMinutes;
    private DateTime _date = DateTime.Now.Date;

    public int GetLengthTimeInMinutes() => _lengthTimeInMinutes;
    public DateTime GetDate() => _date;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary() {
        return $"{GetDate(): dd MMM yyyy} {this.GetType().Name} ({GetLengthTimeInMinutes()} min)- Distance {GetDistance()} km, Speed {GetSpeed()} km/h, Pace: {GetPace()} min per km";
    }

    public BaseActivity(int lengthTimeInMinutes)
    {
        _lengthTimeInMinutes = lengthTimeInMinutes;
    }

}
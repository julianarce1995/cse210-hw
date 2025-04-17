using System;

class Program
{
    static void Main(string[] args)
    {
        List<BaseActivity> activities = new List<BaseActivity>
        {
            new RunningActivity(30, 5),
            new CyclingActivity(45, 18),
            new SwimmingActivity(25, 40),
            new RunningActivity(50, 7),
            new CyclingActivity(90, 23.5),
            new SwimmingActivity(50, 4)
        };

        foreach (BaseActivity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}
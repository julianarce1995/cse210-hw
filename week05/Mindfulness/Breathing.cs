using System;

public class Breathing : Activity
{
    public Breathing(string name, string description): base (name, description){}
    public void Run()
    {
        DisplayStartingMessage();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine("");
        }
        DisplayEndingMessage();
    }
}

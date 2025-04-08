using System;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}.\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationInput = Console.ReadLine();
        _duration = int.Parse(durationInput);
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(4);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(4);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(6);
        Console.Clear();
    }
    public void ShowSpinner(int seconds)
    {

        List<string> animationString = ["|", "/", "-", "\\", "|", "/", "-", "\\"];

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < futureTime)
        {
            string v = animationString[i];
            Console.Write(v);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationString.Count())
            {
                i = 0;
            }
        }
        Console.WriteLine("");
        
    }
    public void ShowCountDown(int seconds)
    {
        List<string> animationNumber = ["1", "2", "3", "4", "5", "6"]; ;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        int i = seconds - 1;
        while (DateTime.Now < futureTime)
        {
            string n = animationNumber[i];
            Console.Write(n);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
            if (i < 0)
            {
                i = 5;
            }
        }
        Console.WriteLine("");
    }
}

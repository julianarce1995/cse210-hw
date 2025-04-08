using System;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts;

    public Listing(string name, string description): base (name, description){}
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        List<string> listFromUser = GetListFromUser();
        _count = listFromUser.Count();
        Console.WriteLine($"You listed {_count} items! \n");
        DisplayEndingMessage();
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(" --- " + GetRandomPrompt() + " --- ");
    }
    public string GetRandomPrompt()
    {
        List<int> randomNumberList = new List<int>();
        Random randomGenerator = new Random();
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
        bool randomNumberExist = false;
        int randomNumber = 0;
        while (!randomNumberExist)
        {
            randomNumber = randomGenerator.Next(_prompts.Count());
            if (!randomNumberList.Contains(randomNumber))
            {
                randomNumberList.Add(randomNumber);
                randomNumberExist = true;
            }
        }
        return _prompts[randomNumber];
    }
    public List<string> GetListFromUser()
    {
        List<string> listItems = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write(">");
            string list = Console.ReadLine();
            listItems.Add(list);
        }
        return listItems;
    }
}

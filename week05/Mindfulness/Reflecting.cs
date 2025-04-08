using System;
using System.Runtime.CompilerServices;

public class Reflecting : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<int> randomNumberListInQuestions = new List<int>();

    public Reflecting(string name, string description): base (name, description){}
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(4);
        Console.Clear();
        DisplayQuestions();
        DisplayEndingMessage();  
    }
    public string GetRandomPrompt()
    {
        List<int> randomNumberList = new List<int>();
        Random randomGenerator = new Random();
        _prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
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
    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];
        bool randomNumberExist = false;
        int randomNumber = 0;
        while (!randomNumberExist)
        {
            randomNumber = randomGenerator.Next(_prompts.Count());
            if (!randomNumberListInQuestions.Contains(randomNumber))
            {
                randomNumberListInQuestions.Add(randomNumber);
                randomNumberExist = true;
            }
        }
        return _questions[randomNumber];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine(" --- " + GetRandomPrompt() + " --- ");
    }
    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write(">" + GetRandomQuestion() + " ");
            ShowSpinner(15);
        }
        Console.WriteLine("");
    }
}

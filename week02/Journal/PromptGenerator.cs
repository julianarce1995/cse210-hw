using System;

public class PromptGenerator
{
    public List<String> _prompts;

    public string GetRandomPrompt()
    {
        string[] promptLines = System.IO.File.ReadAllLines("prompts.txt");
        Random random = new Random();
        int randomIndex = random.Next(promptLines.Count());
        string ramdonPrompt = promptLines[randomIndex];
        return ramdonPrompt;
    }
}
using System;

public class Entry
{
    public String _date;
    public String _promptText;
    public String _entryText;

     public void Display()
    {
        Console.WriteLine("Date:" +_date + " - " + "Prompt: " + _promptText);
        Console.WriteLine(_entryText);
        Console.WriteLine("");
    }
}
using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string answer = "";
        string bookName = "Proverbs";
        int chapterNumber = 3;
        int startVerseNumber = 5;
        int endVerseNumber = 6;
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference = new Reference(bookName, chapterNumber, startVerseNumber, endVerseNumber);
        Scripture scripture = new Scripture(reference, text);
        Console.Clear();
        while (answer != "quit")
        {
            if (!scripture.IsCompletelyHidden())
            {
                scripture.HideRandomWords(3);
                string scriptureWords = scripture.GetDisplayText();
                Console.WriteLine(scriptureWords);
                Console.WriteLine("press the enter key or type quit");
                answer = Console.ReadLine();
                Console.Clear();
            }
            else
            {
                answer = "quit";
            }

        }
    }
}
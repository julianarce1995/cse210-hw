using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string chooseInput = "";
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (chooseInput != "5")
        {
            Console.WriteLine("Please Select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What do you like to do? ");
            chooseInput = Console.ReadLine();


            switch (chooseInput)
            {
                case "1":
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    string answerInput = Console.ReadLine();

                    Entry entry = new Entry();
                    entry._entryText = answerInput;
                    entry._date = dateText;
                    entry._promptText = randomPrompt;

                    journal.AddEntry(entry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("What is the filename?");
                    string fileNameToLoad = Console.ReadLine();

                    journal.LoadFromFile(fileNameToLoad);
                    break;
                case "4":
                    Console.Write("What is the filename?");
                    string fileNameToSave = Console.ReadLine();

                    journal.SaveToFile(fileNameToSave);
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
    }
}
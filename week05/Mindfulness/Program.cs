using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Boolean quit = true;
        while (quit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string menuSelection = Console.ReadLine();
            Console.Clear();
            if (menuSelection == "1")
            {
                string breathingActivityString = "Breathing Activity";
                string breathingDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Breathing breathingActivity = new Breathing(breathingActivityString, breathingDescription);
                breathingActivity.Run();
            }
            else if (menuSelection == "2")
            {
                string reflectingActivityString = "Reflecting Activity";
                string reflectingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Reflecting reflectingActivity = new Reflecting(reflectingActivityString, reflectingDescription);
                reflectingActivity.Run();
            } else if (menuSelection == "3")
            {
                string listingActivityString = "Listing Activity";
                string listingDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                Listing listingActivity = new Listing(listingActivityString, listingDescription);
                listingActivity.Run();
            }
            if (menuSelection == "4")
            {
                quit = false;
            }
        }
    }
}
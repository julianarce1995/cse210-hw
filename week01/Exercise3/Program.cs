using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        Console.WriteLine(magicNumber);
        Console.Write("What is your guess?: ");
        string userNumberInput = Console.ReadLine();
        int userNumber = int.Parse(userNumberInput);
        bool condition = true;
        do
        {
            if (userNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (userNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                condition = false;
            }
            if (magicNumber != userNumber)
            {
                Console.Write("What is your guess?: ");
                userNumberInput = Console.ReadLine();
                userNumber = int.Parse(userNumberInput);
            }
        } while (condition);
    }
}
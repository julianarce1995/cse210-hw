using System;
class Program
{
    static void Main(string[] args)
    {
        int number = 1;
        List<int> numbers = [];
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberToAddInput = Console.ReadLine();
            int numberToAdd = int.Parse(numberToAddInput);
            if (numberToAdd == 0)
            {
                number = numberToAdd;
            }
            else
            {
                numbers.Add(numberToAdd);
            }
        }
        int sum = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum = numbers[i] + sum;
        }
        Console.WriteLine($"the sum is: {sum}");
        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int largestNumber = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}
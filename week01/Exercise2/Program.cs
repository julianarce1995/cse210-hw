using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentageInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageInput);
        string letterGrade = "";
        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        } else if (gradePercentage >= 80)
        {
            letterGrade = "B";
        } else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        } else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        } else if (gradePercentage < 60)
        {
            letterGrade = "F";
        }
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations you pass the class");
        }
        else
        {
            Console.WriteLine("Sorry you don't pass the class");
        }
        Console.WriteLine($"your letter grade is = {letterGrade}");
    }
}
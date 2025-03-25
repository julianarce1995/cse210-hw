using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions(1);
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());
        Fractions fraction2 = new Fractions(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());
        Fractions fraction3 = new Fractions(3, 4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());
        Fractions fraction4 = new Fractions(1, 3);
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        /*
        fraction1.SetTop(2);
        fraction1.SetBotton(2);
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction1.GetBotton());
        */
    }
}
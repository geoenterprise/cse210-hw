using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is the Results of the fraction class");
        Fraction fraction1 = new Fraction();
        Console.WriteLine($"fraction1: {fraction1.GetFractionString()}");
        Console.WriteLine(fraction1.GetDecimalValue());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine($"fraction2: {fraction2.GetFractionString()}");
        Console.WriteLine(fraction2.GetDecimalValue());

        Fraction fraction3 = new Fraction(6, 2);
        Console.WriteLine($"fraction3: {fraction3.GetFractionString()}");
        Console.WriteLine($"{fraction3.GetDecimalValue():F2}");
    }
    
}

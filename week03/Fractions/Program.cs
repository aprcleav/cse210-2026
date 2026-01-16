using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction f = new Fraction();

        f.GetTop();
        f.GetBottom();
        f.GetFractionString();
        Console.WriteLine(f.GetDecimalValue());

        f.SetTop(3);
        f.SetBottom(4);
        f.GetFractionString();
        Console.WriteLine(f.GetDecimalValue());




    }
}

// Run more tests, and reread instructions to see if completed correctly.
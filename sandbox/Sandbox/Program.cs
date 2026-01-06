using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        Console.WriteLine("This is in C#.");

        int number = 5;

        if (number > 3)
        {
            Console.WriteLine("greater");
        }

        Console.Write("What is your favorite color?");
        string color = Console.ReadLine();
        Console.WriteLine($"Your favorite color is {color}.");
        
    }
}
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbersList = new List<int>();

        // Add numbers to list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;
        int sum = 0;
        int largest = -999999999;
        int smallest = 999999999;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbersList.Add(userNumber);
            }
        }

        // Calculate sum, largest, and smallest positive number
        foreach (int number in numbersList)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
            if (number < smallest && number > 0)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate average
        double average = ((double)sum) / numbersList.Count;
        Console.WriteLine($"The average is: {average}");

        //Display largest number and smallest positive number
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");

        //Sort list from smallest to largest number
        numbersList.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbersList)
        {
            Console.WriteLine(num);
        } 


    }
}
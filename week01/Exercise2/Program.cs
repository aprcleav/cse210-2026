using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? (example: 90) ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        string letter = "";
        string sign;
        int lastDigit = grade % 10;

        // Finds letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        // Determines if letter grade is + or -
        if (lastDigit >= 7)
        {
            if (letter == "A" || letter == "F")
            {
                sign = "";
            }
            else
            {
                sign = "+";
            }
        }
        else if (lastDigit < 3)
        {
            if (letter == "F")
            {
                sign = "";
            }
            else
            {
                sign = "-";
            }
        }
        else
        {
            sign = "";
        }

        // Displays pass or fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You failed this time, but keep trying. You can do it!");
        }

        // Displays final letter grade with sign
        Console.WriteLine($"Your letter grade is: {letter}{sign}");
    }
}
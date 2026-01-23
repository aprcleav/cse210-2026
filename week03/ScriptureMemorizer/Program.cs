using System;
// Showing Creativity: I added a LoadRandomScripture() factory method to my scripture class that reads from a "ScriptureLibrary.txt" file I created. It chooses a random line and sets all the corresponding variables, then instantiates the reference and returns the random scripture. I ended up removing the Show() method from my Word class because I never needed to call it.

class Program
{
    static void Main(string[] args)
    {
        //This was the hardcoded reference and scripture that I started with, before I added the LoadRandomScripture() method.
        // Reference reference = new Reference("Doctrine & Covenants", 8, 2, 3);
        // Scripture scripture = new Scripture(reference, "Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground.");

        Scripture scripture = Scripture.LoadRandomScripture(); //Gets random scripture

        Console.Clear();
        scripture.GetDisplayText();

        Console.WriteLine();
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
        string userInput = Console.ReadLine();

        do
        {
            if (userInput == "")
            {
                Console.Clear();
                scripture.HideRandomWords(4);
                scripture.GetDisplayText();
                Console.WriteLine();
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
                userInput = Console.ReadLine();
                if (scripture.IsCompletelyHidden())
                {
                    break;
                }
            }
        } while (userInput != "quit");

    }
}
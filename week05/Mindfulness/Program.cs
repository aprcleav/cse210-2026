using System;
// Showing Creativity: I added the GetRandomItem() method to the Activity class. It prevents repeated prompts by keeping track of remaining items in a separate list, and removes an item each time it is used. Once the list is empty, it repopulates with the original list. I call this function in my GetRandomPrompt() methods in the Listing and Reflecting activity classes and use a _prompts list and a _remainingPrompts list as parameters. I used AI to help me figure out how to do this, and tried a few other things before settling on this approach. 
class Program
{
    static void Main(string[] args)
    {
        string menuChoice;

        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            if (!new[] { "1", "2", "3", "4" }.Contains(menuChoice))
            // Handles errors if user enters something other than 1-4
            {
                Console.WriteLine("Please enter a valid number (1-4)");
            }

            if (menuChoice == "1")
            {
                BreathingActivity b1 = new BreathingActivity();
                b1.Run();
            }

            else if (menuChoice == "2")
            {
                ReflectingActivity r1 = new ReflectingActivity();
                r1.Run();
            }

            else if (menuChoice == "3")
            {
                ListingActivity l1 = new ListingActivity();
                l1.Run();
            }
            else
            {
                break;
            }

        } while (menuChoice != "4");

    }
}
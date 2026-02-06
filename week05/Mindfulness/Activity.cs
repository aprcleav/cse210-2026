using System.Diagnostics;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "Unknown";
        _description = "Unknown";
        _duration = 0;
    }
    
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...\n");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(5);
        Console.WriteLine($"\nYou've completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animations = new List<string> {"|", "/", "-", "\\"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }
        
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    protected string GetRandomItem(List<string> items, List<string> remaining)
    // Generates a random item from a list and ensures no duplicates by keeping track of remianing items in a separate list, and removing an item each time it is used. Once the list is empty, it repopulates with the original list. I call this function in my GetRandomPrompt() methods in the Listing and Reflecting activity classes and use a _prompts list and a _remainingPrompts list as parameters.
    {
        if (remaining.Count == 0)
        {
            remaining.AddRange(items);
        }

        int index = Random.Shared.Next(remaining.Count);
        string item = remaining[index];
        remaining.RemoveAt(index);
        return item;
    }
}   
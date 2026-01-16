public class Entry
{
    public string _response;
    public string _prompt;
    public string _date;
    public string _mood;

    public void NewEntry()
    // Gets current date and stores it, generates and stores a random prompt, and stores user response. I added a variable to track mood over time as well.
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();

        Console.WriteLine("How are you feeling today? (1 is bad, 5 is excellent)");
        Console.Write(">> ");
        _mood = Console.ReadLine();

        Console.WriteLine();
        Prompt genRandom = new Prompt();
        _prompt = genRandom.GeneratePrompt();

        Console.WriteLine(_prompt);
        Console.Write(">> ");
        _response = Console.ReadLine();
    }

    public void DisplayEntry()
    {
        Console.WriteLine();
        Console.WriteLine($"{_date}: {_prompt}");
        Console.WriteLine($">> {_response}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine();
    }
}
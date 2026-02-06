public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts;

    private List<string> _remainingPrompts;
    
    public ListingActivity()
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        SetDuration(30);
        _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
        _remainingPrompts = new List<string>(_prompts);
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayReady();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Display as many responses you can to the following prompt:");
            Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
            Console.Write("\nYou may begin in...");
            ShowCountDown(5);
            Console.WriteLine();
            List<string> userResponses = new List<string>();
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string response = Console.ReadLine();
                userResponses.Add(response);
                _count = userResponses.Count();
            }
        }
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        return GetRandomItem(_prompts, _remainingPrompts);
    }

}
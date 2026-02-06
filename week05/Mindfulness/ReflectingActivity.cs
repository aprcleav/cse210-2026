using System.Net;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private List<string> _remainingPrompts;

    private List<string> _remainingQuestions;

    public ReflectingActivity()
    {
        SetName("Reflection");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        SetDuration(30);
        _prompts = new List<string> { "Think of a time when you stood up for your beliefs.", "Think of a time when you accomplished something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
        _questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
        _remainingPrompts = new List<string>(_prompts);
        _remainingQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayReady();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        string response = "";

        while (DateTime.Now < endTime && response == "")
        {
            DisplayPrompt();

            Console.WriteLine("When you have something in mind, press enter to continue.");
            response = Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();

            while (DateTime.Now < endTime)
            {
                DisplayQuestions();
            }

        }
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    // Generates a random prompt and ensures no duplicates
    {
        return GetRandomItem(_prompts, _remainingPrompts);
    }

    private string GetRandomQuestion()
    // Generates random question and ensures no duplicates using the same logic as GetRandomItem() in the Activity class
    {
        if (_remainingQuestions.Count == 0)
        {
            _remainingQuestions = new List<string>(_questions);
        }

        int index = Random.Shared.Next(_remainingQuestions.Count);
        string question = _remainingQuestions[index];
        _remainingQuestions.RemoveAt(index);
        return question;
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
    }
    private void DisplayQuestions()
    {

        Console.WriteLine($"> {GetRandomQuestion()}");
        ShowSpinner(7);

    }

}
public class Prompt
{
    public static Random _rand = new Random(); // Static so it's created only once (to prevent repeated prompts)
    List<string> _prompts = new List<string> { "What are you grateful for today?", "Describe a challenge you recently overcame.", "In was ways could daily prayer contribute to your happiness and wellbeing?", "What is your favorite childhood memory?", "What new skills or habits would you like to learn?", "How did you see the hand of the Lord in your life today?", "What personal strengths help you the most during trials?", "What are some spiritual gifts that you have, and some that you'd like to gain?", "What does your ideal day look like?", "How do you handle stress?", "How can you show love and support to someone today?" };

    public string GeneratePrompt()
    // Generates a random prompt from the _prompts list
    {
        int index = _rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
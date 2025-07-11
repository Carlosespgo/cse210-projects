using System.ComponentModel;
using System.Xml.Linq;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>{"If you could change one thing about today, what would it be?", "How could you feel the hand of the lord on this day?", "What is the most important thing you did today?", "Tells a funny story about today (every day has a funny part)", "What lessons will you keep from this day?"};

    public string GetRandomPrompt()
    {
        Random randomWord = new Random();
        int indexRandom = randomWord.Next(_prompts.Count);
        return _prompts[indexRandom];
    }
}
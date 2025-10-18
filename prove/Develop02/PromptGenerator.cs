using System;

public class PromptGenerator
{
    public List<string> _prompts;
    public Random _randomizer;

    public PromptGenerator()
    {
        _prompts = new List<string>();
        _randomizer = new Random();

        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public string RandomPrompt()
    {
        return _prompts[_randomizer.Next(_prompts.Count)];
    }
}
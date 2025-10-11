using System;

public class PromptGenerator
{
    public List<string> Prompts;
    public Random Randomizer;

    public PromptGenerator()
    {
        Prompts = new List<string>();
        Randomizer = new Random();

        Prompts.Add("Who was the most interesting person I interacted with today?");
        Prompts.Add("What was the best part of my day?");
        Prompts.Add("How did I see the hand of the Lord in my life today?");
        Prompts.Add("What was the strongest emotion I felt today?");
        Prompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public string RandomPrompt()
    {
        return Prompts[Randomizer.Next(Prompts.Count)];
    }
}
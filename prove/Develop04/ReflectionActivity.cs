public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _randomReflection;

    public ReflectionActivity()
        : base("Reflection",
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                0)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?"
        };

        _randomReflection = new Random();
    }

    public void Run()
    {
        GreetingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        while (DateTime.Now < endTime)
        {
        string prompt = _prompts[_randomReflection.Next(_prompts.Count)];
            Console.WriteLine($"{prompt}");
            SpinnerAnimation(5);
        
        string question = _questions[_randomReflection.Next(_questions.Count)];
            Console.WriteLine($"{question}");
            SpinnerAnimation(5);
        }
    }
}
public class ListingActivity : Activity
{
    private List<string> _questions;
    private Random _randomList;
    public ListingActivity()
        : base("Listing",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                0)
    {
        _questions = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _randomList = new Random();
    }

    public void Run()
    {
        GreetingMessage();

        Console.WriteLine("Get Ready. . .");
        SpinnerAnimation(4);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("You may begin in:");
        CountDown(5);

        string question = _questions[_randomList.Next(_questions.Count)];
        Console.WriteLine($"{question}");

        List<string> userInput = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                userInput.Add(input);
            }
        }
        Console.WriteLine($"You listed {userInput.Count} responses!");
        
        EndingMessage();
    }
    

}
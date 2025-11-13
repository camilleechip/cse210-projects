using System.Threading;

public class Activity
{
    private string _activity;
    private string _description;
    private int _duration;

    public Activity(string activity, string description, int duration)
    {
        _activity = activity;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void GreetingMessage()
    {
        Console.WriteLine($"Welcome to the {_activity} activity!");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");

        bool time = false;
        while (!time)
        {
            Console.WriteLine($"How long, in seconds, would you like for your session?");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int duration))
            {
                _duration = duration;
                time = true;
            }

            else
            {
                Console.WriteLine("invalid input.");
            }
        }

        Console.WriteLine("Get Ready to begin.");
        SpinnerAnimation(5);
        
    }

    public void SpinnerAnimation(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;


        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i = (i + 1) % animationStrings.Count;
        }
    }

    public void CountDown(int seconds)
    {
        for (int i = 5; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }    
    }
    
    public void EndingMessage()
    {
        Console.WriteLine("You did a wonderful job!");
        SpinnerAnimation(3);

        Console.WriteLine($"You have completed the {_activity} activity for {_duration} seconds.");
        SpinnerAnimation(3);
    }
}
public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                0)
    {
    }

    public void Run()
    {
        GreetingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in. . .");
            CountDown(5);

            Console.Write("Breathe out. . .");
            CountDown(5);
        }

        EndingMessage();
    }

}
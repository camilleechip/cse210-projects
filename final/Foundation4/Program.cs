using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(30, new DateTime(2022, 11,03), 3.5));
        activities.Add(new Cycling(50, new DateTime(2025, 12, 10), 5.0));
        activities.Add(new Swimming(45, new DateTime(2025, 10, 30), 30));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}
using System;


// To exceed requirements I added a function that counts how many time each activity is performed.
// The function also adds the total amount of activites done as well.
class Program
{
    static void Main(string[] args)
    {
        int breathingActivityCount = 0;
        int reflectionActivityCount = 0;
        int listingActivityCount = 0;

        bool usingMenu = true;

        while (usingMenu)
        {
            Console.Clear();
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                breathingActivityCount++;
            }

            if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
                reflectionActivityCount++;
            }

            if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
                listingActivityCount++;
            }

            if (choice == "4")
            {
                Console.WriteLine("Goodbye");
                usingMenu = false;
                break;
            }
        }

        int totalActivities = breathingActivityCount + reflectionActivityCount + listingActivityCount;

        Console.WriteLine("Session Summary:");
        Console.WriteLine($"Breathing Activity: {breathingActivityCount} times.");
        Console.WriteLine($"Reflection Activity: {reflectionActivityCount} times.");
        Console.WriteLine($"Listing Activity: {listingActivityCount} times.");
        Console.WriteLine($"Total activities performed: {totalActivities}");
    }
}
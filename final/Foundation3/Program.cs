using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("Eagle Mountain", "UT", "USA");
        Address receptionAddress = new Address("Riverton", "UT", "USA");
        Address outdoorAddress = new Address("Saratoga Springs", "UT", "USA");

        Lecture lecture = new Lecture("Economics 101", "Introductory course that covers concepts of supply and demand.",
            new DateTime(2025, 12, 19, 14, 0, 0), lectureAddress, "Professor Huggins", 50);

        Reception reception = new Reception("Huggins Ceremony", "Join us for Tanner and Camille Huggins wedding.",
            new DateTime(2018, 11, 23, 17, 0, 0), receptionAddress, "");
        bool usingMenu = true;

        OutdoorGathering outdoorGathering = new OutdoorGathering("Happy Birthday Quinn!", "January 12th we will be celebrating Quinn's second birthday with cake, games and lots of fun!",
            new DateTime(2026, 01, 12, 12, 30, 0), outdoorAddress, "");

        while (usingMenu)
        {
            Console.WriteLine("Select an Event:");
            Console.WriteLine("1. Lecture");
            Console.WriteLine("2. Reception");
            Console.WriteLine("3. Outdoor Gathering");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine($"--Lecture--");
                Console.WriteLine($"Description: {lecture.GetShortDescription()}");
                Console.WriteLine();
                Console.WriteLine($"Standard Details: {lecture.GetStandardDetails()}");
                Console.WriteLine();
                Console.WriteLine($"Full Details: {lecture.GetFullDetails()}");
                Console.WriteLine();
            }

            if (choice == "2")
            {
                Console.WriteLine("Would you like to RSVP? (y/n):");
                string response = Console.ReadLine();

                if (response == "y")
                {
                    Console.WriteLine("Enter your email:");
                    string email = Console.ReadLine().ToLower();
                    reception.SetRSVP(true);
                    reception.SetEmail(email);

                    Console.WriteLine("RSVP Confirmed!");
                }

                else
                {
                    reception.SetRSVP(false);
                }

                Console.WriteLine("--Reception--");
                Console.WriteLine($"Description: {reception.GetShortDescription()}");
                Console.WriteLine();
                Console.WriteLine($"Standard Details: {reception.GetStandardDetails()}");
                Console.WriteLine();
                Console.WriteLine($"Full Details: {reception.GetFullDetails()}");
                Console.WriteLine();
            }

            if (choice == "3")
            {
                Console.WriteLine($"--Outdoor Gathering--");
                Console.WriteLine($"Description: {outdoorGathering.GetShortDescription()}");
                Console.WriteLine();
                Console.WriteLine($"Standard Details: {outdoorGathering.GetStandardDetails()}");
                Console.WriteLine();
                Console.WriteLine($"Full Details: {outdoorGathering.GetFullDetails()}");
                Console.WriteLine();               
            }

            if (choice == "4")
            {
                Console.WriteLine("Goodbye.");
                break;
            }
        }
    }
}
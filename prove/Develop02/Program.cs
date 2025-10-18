using System;
using System.Collections.Generic;
using System.IO;


//I added a prompt that asked the user their mood for the day.
//This goes along with 1. Write a new entry:

class Program
{
    static void Main(string[] args)
    {

        List<Entry> entries = new List<Entry>();
        PromptGenerator generator = new PromptGenerator();
        bool usingMenu = true;

        while (usingMenu)
        {
            Console.WriteLine("Welcome to your Journal");
            Console.WriteLine("1. Write a new entry:");
            Console.WriteLine("2. Display the journal:");
            Console.WriteLine("3. Save the Journal to a file:");
            Console.WriteLine("4. Load the journal from a file:");
            Console.WriteLine("5. Quit.");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                string prompt = generator.RandomPrompt();
                Console.Write($"{prompt}");
                string entry = Console.ReadLine();

                Console.WriteLine("How are you feeling today?");
                string mood = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _prompt = prompt,
                    _entry = entry,
                    _mood = mood
                };
                entries.Add(newEntry);
            }

            else if (choice == "2")
            {
                Console.WriteLine("Your journal entries:");
                foreach (Entry entry in entries)
                {
                    Console.WriteLine($"{entry._date} | {entry._prompt} | {entry._entry}");
                }
            }

            else if (choice == "3")
            {
                Console.WriteLine("Enter a filename to save:");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    foreach (Entry entry in entries)
                    {
                        outputFile.WriteLine($"{entry._date} | {entry._prompt} | {entry._entry}");
                    }
                }
            }

            else if (choice == "4")
            {
                Console.WriteLine("Enter filename:");
                string filename = Console.ReadLine();

                if (File.Exists(filename))
                {
                    string[] lines = File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            else if (choice == "5")
            {
                break;
            }

        }
    }
}
    
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

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

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _prompt = prompt,
                    _entry = entry
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
                string filename = "journal.txt";

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
    
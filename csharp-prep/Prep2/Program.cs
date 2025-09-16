using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage?");
        string percentage = Console.ReadLine();
        int number = int.Parse(percentage);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (number >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else if (number < 70)
        {
            Console.WriteLine("You failed.");
        }
        

    }
}
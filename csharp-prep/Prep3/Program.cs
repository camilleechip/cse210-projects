using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);

        int number;

        do
        {
            Console.Write("What is your guess?");
            string guess = Console.ReadLine();
            number = int.Parse(guess);

            if (number == magicNum)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (number > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (number < magicNum)
            {
                Console.WriteLine("Higher");
            }
        } while (number != magicNum);
    }
    


}
using System;


//I asked the user for a scripture instead of supplying one.
//This scripture is then saved to a file.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the book:");
        string book = Console.ReadLine();

        Console.WriteLine("Enter chapter number:");
        int chapter = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter starting verse number:");
        int verse = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter ending verse number (press enter if single verse):");
        string singleVerse = Console.ReadLine();
        int endVerse = string.IsNullOrEmpty(singleVerse) ? verse : int.Parse(singleVerse);

        Console.WriteLine("Enter the scripture text:");
        string text = Console.ReadLine();

        Reference reference = new Reference(book, chapter, verse, endVerse);
        Scripture scripture = new Scripture(reference, text);

        bool usingMenu = true;

        while (usingMenu)
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            string choice = Console.ReadLine();

            //figure out how to hide words in scripture class
            if (string.IsNullOrEmpty(choice))
            {
                scripture.HideWords(1);

                if (scripture.AllWordsHidden())
                {
                    Console.Clear();
                    scripture.DisplayScripture();
                    Console.WriteLine("All words hidden!");
                    break;
                }
            }

            else if (choice == "quit")
            {
                break;
            }
        }
    }
}

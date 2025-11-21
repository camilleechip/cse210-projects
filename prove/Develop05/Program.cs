using System;
using System.Linq;


// I exceeded requirements by adding levels to the total points the user has. 
class Program
{
    static void Main(string[] args)
    { 
        SimpleGoal.LoadFromFile();
        EternalGoal.LoadFromFile();
        ChecklistGoal.LoadFromFile();

        bool usingMenu = true;
        while (usingMenu)
        {
            int totalPoints = Goal.AllGoals.Sum(g => g.EarnedPoints());
            Console.WriteLine($"Total Points: {totalPoints}\nLevel: {Goal.GetPlayerLevel()}");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu:");

            string choice = Console.ReadLine();
            if (choice == "1") { Console.WriteLine("The types of Goals are:"); 
            Console.WriteLine("1. Simple Goal"); 
            Console.WriteLine("2. Eternal Goal"); 
            Console.WriteLine("3. CheckList Goal"); 
            Console.WriteLine("Which of these goals would you like to create?"); 
            
            string options = Console.ReadLine(); 
            
                if (options == "1") 
                { 
                    Console.WriteLine("What is the name of your goal?"); 
                    string name = Console.ReadLine(); 
            
                    Console.WriteLine("What is a short description of your goal?"); 
                    string description = Console.ReadLine(); 
            
                    Console.WriteLine("How many points will be associated with this goal?"); 
                    int points = int.Parse(Console.ReadLine());

                    SimpleGoal newGoal = new SimpleGoal(false, points, name, description);

                    Goal.AllGoals.Add(newGoal);
                    Console.WriteLine("Goal added!");
                }

                if (options == "2")
                {
                    Console.WriteLine("What is the name of your goal?"); 
                    string name = Console.ReadLine(); 
            
                    Console.WriteLine("What is a short description of your goal?"); 
                    string description = Console.ReadLine(); 
            
                    Console.WriteLine("How many points will be associated with this goal?"); 
                    int points = int.Parse(Console.ReadLine());

                    EternalGoal newGoal = new EternalGoal(false, points, name, description);

                    Goal.AllGoals.Add(newGoal);
                    Console.WriteLine("Goal added!");
                }

                if (options == "3")
                {
                    Console.WriteLine("What is the name of your goal?"); 
                    string name = Console.ReadLine(); 
            
                    Console.WriteLine("What is a short description of your goal?"); 
                    string description = Console.ReadLine(); 
            
                    Console.WriteLine("How many points will be associated with this goal?"); 
                    int points = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                    int progressDenominator = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many bonus points for completion?");
                    int progressPoints = int.Parse(Console.ReadLine());

                    ChecklistGoal newGoal = new ChecklistGoal(false, points, name, description, progressDenominator, progressPoints);

                    Goal.AllGoals.Add(newGoal);
                    Console.WriteLine("Goal added!");
                }
            } 

            if (choice == "2")
            {
                int i = 1;
                foreach (Goal goal in Goal.AllGoals)
                {
                    Console.WriteLine($"{i}. {goal.PrintProgress()} {goal.GetName()} ({goal.GetDescription()}) : {goal.GetPoints()}");
                    i++;
                }
            }

            if (choice == "3")
            {
                foreach (Goal goal in Goal.AllGoals)
                {
                    goal.SaveToFile();
                }
                Console.WriteLine("All goals saved.");
            }

            if (choice == "4")
            {
                Goal.AllGoals.Clear();

                SimpleGoal.LoadFromFile();
                EternalGoal.LoadFromFile();
                ChecklistGoal.LoadFromFile();

                Console.WriteLine("All goals loaded!");
            }

            if (choice == "5")
            {
                Console.WriteLine("Which goal did you accomplish?");;
                int index = int.Parse(Console.ReadLine()) - 1;

                Goal chosen = Goal.AllGoals[index];
                chosen.UpdateCompletion();

                Console.WriteLine("Event recorded!");
            }

            if (choice == "6")
            {
                Console.WriteLine("Goodbye");
                usingMenu = false;
                break;
            }
        }
    }
}
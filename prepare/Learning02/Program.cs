using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._jobTitle = "software engineer";
        Job1._company = "Microsoft";
        Job1._startYear = 2019;
        Job1._endYear = 2022;

        Job Job2 = new Job();
        Job2._jobTitle = "manager";
        Job2._company = "Apple";
        Job2._startYear = 2022;
        Job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        myResume._jobs.Add(Job1);
        myResume._jobs.Add(Job2);

        myResume.DisplayResume();
    }
}

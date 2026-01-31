using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Manager";
        job1._company = "Wendy's";
        job1._startYear = 2003;
        job1._endYear = 2019;
        
        Job job2 = new Job();
        job2._jobTitle = "Super manager";
        job2._company = "Denny's";
        job2._startYear = 2020;
        job2._endYear = 2026;

        Resume myResume = new Resume();

        myResume._name = "John";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        
    }
}
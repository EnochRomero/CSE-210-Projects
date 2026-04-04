using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Cycling cycling1 = new Cycling("4/4/26", 5, 10);

        Running running1 = new Running("4/1/20", 60, 10);

        Swimming swimming1 = new Swimming("9/15/20", 10, 4);

        activities.Add(cycling1);
        activities.Add(running1);
        activities.Add(swimming1);


        foreach (Activity activity in activities)
        {
            activity.DisplaySummary();
        }






    }
}
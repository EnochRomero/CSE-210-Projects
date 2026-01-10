using System;

class Program
{
    static void Main(string[] args)
    {
        string grade = "";

        Console.Write("Enter score percent to get grade: ");
        string stringScore = Console.ReadLine();
        int intScore = int.Parse(stringScore);

        if (intScore >= 90)
        {
            grade = "A";
        }

        else if (intScore >= 80)
        {
            grade = "B";
        }

        else if (intScore >= 70)
        {
            grade = "C";
        }

        else if (intScore >= 60)
        {
            grade = "D";
        }

        else
        {
            grade = "F";
        }

        Console.WriteLine($"The grade is {grade}");

        if (intScore >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You Failed");
        }

    }
}
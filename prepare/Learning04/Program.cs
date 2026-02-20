using System;

class Program
{
    static void Main(string[] args)
    {
        
        EnglishAssignment assignment1 = new EnglishAssignment("Enoch Romero", "English 101", "Final Paper");

        Console.WriteLine(assignment1.GetWritingInformation());

        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Enoch Romero", "Fractions","Section 9", "Problems 1-10" );

        Console.WriteLine(assignment2.GetHomeWorkList());

        Console.WriteLine();

        Assignment assignment3 = new Assignment ("Enoch Romero", "General Studies");

        Console.WriteLine(assignment3.GetSummary());
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {

        string choice = "0";

        double goalPoints = 0;

        List<Goal> goalList = new List<Goal>();


        static void DisplayMenu()
        {

            Console.WriteLine("Please Select One of the Following Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
        }



        while (choice != "6")
        {
            Console.WriteLine($"You Currently Have {goalPoints} points");
            Console.WriteLine();

            DisplayMenu();
            choice = Console.ReadLine();


            if (choice == "1") // Create New Goal
            {
                Console.WriteLine("What Kind of Goal would You Like to Make?");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("4. Exponential Goal");

                string goalChoice = "0";

                goalChoice = Console.ReadLine();

                if (goalChoice == "1") // simple
                {

                    Console.WriteLine("What would you like to title your goal?");
                    string title = Console.ReadLine();


                    Console.WriteLine("Write a description of your goal");
                    string desc = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth?");
                    double points = double.Parse(Console.ReadLine());


                    SimpleGoal newGoal = new SimpleGoal(title, desc, points, false);


                    goalList.Add(newGoal);


                }

                if (goalChoice == "2") // eternal
                {

                    Console.WriteLine("What would you like to title your goal?");
                    string title = Console.ReadLine();


                    Console.WriteLine("Write a description of your goal");
                    string desc = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth?");
                    double points = double.Parse(Console.ReadLine());

                    EternalGoal newGoal = new EternalGoal(title, desc, points);

                    goalList.Add(newGoal);
                    
                }

                if (goalChoice == "3") // checklist
                {
                    Console.WriteLine("What would you like to title your goal?");
                    string title = Console.ReadLine();


                    Console.WriteLine("Write a description of your goal");
                    string desc = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth?");
                    double points = double.Parse(Console.ReadLine());

                    Console.WriteLine("How many times do you want to do this goal to get bonus points?");
                    int bonusGoalAmount = int.Parse(Console.ReadLine());

                    Console.WriteLine("How many bonus points do you want for doing your goal that many times?");
                    double bonusPoints = double.Parse(Console.ReadLine());

                    ChecklistGoal newGoal = new ChecklistGoal(title, desc, points, false, bonusGoalAmount, 0, bonusPoints);

                    goalList.Add(newGoal);
                }

                if (goalChoice == "4") // exponential
                {

                    Console.WriteLine("What would you like to title your goal?");
                    string title = Console.ReadLine();

                    Console.WriteLine("Write a description of your goal");
                    string desc = Console.ReadLine();

                    Console.WriteLine("How many points is this goal worth?");
                    double points = double.Parse(Console.ReadLine());

                    ExponentialGoal newGoal = new ExponentialGoal(title, desc, points);

                    goalList.Add(newGoal);
                    
                }

            }

            if (choice == "2") // List Goals
            {

                int listCount = 1;

                foreach (Goal goal in goalList)
                {

                    Console.Write(listCount + ".");
                    Console.WriteLine(goal.DisplayProgress());
                    listCount ++;
                }
                
            }

            if (choice == "3") // Save Goals
            {
                Console.WriteLine("What file would you like to save these goals to?");
                string file = Console.ReadLine();

                System.IO.File.WriteAllText(file, string.Empty);

                using (StreamWriter output = new StreamWriter(file, false))
                {
                output.WriteLine(goalPoints);
                
                    foreach (Goal goal in goalList)
                    {
                        output.WriteLine(goal.GetSaveString());
                    }
                }

                
            }

            if (choice == "4") // Load Goals
            {

                Console.WriteLine("What file would you like to load?");
                string file = Console.ReadLine();

                string[] lines = File.ReadAllLines(file);

                goalList.Clear();

                goalPoints = double.Parse(lines[0]);

                foreach (string line in lines.Skip(1))
                {
                    string[] parts = line.Split("|");

                    if (parts[0] == "SimpleGoal")
                    {
                        SimpleGoal newGoal = new SimpleGoal(parts[1], parts[2], double.Parse(parts[3]), bool.Parse(parts[4]));

                        goalList.Add(newGoal);
                    }

                    if (parts[0] == "EternalGoal")
                    {
                        EternalGoal newGoal = new EternalGoal(parts[1], parts[2], double.Parse(parts[3]));

                        goalList.Add(newGoal);
                    }

                    if (parts[0] == "ChecklistGoal")
                    {
                        ChecklistGoal newGoal = new ChecklistGoal(parts[1], parts[2], double.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]),int.Parse(parts[6]), double.Parse(parts[7]));

                        goalList.Add(newGoal);
                    }

                    if (parts[0] == "ExponentialGoal")
                    {
                        ExponentialGoal newGoal = new ExponentialGoal(parts[1], parts[2], double.Parse(parts[3]));
                    }
                }

            }

            if (choice == "5") // Record Event
            {
                int listCount = 1;

                foreach (Goal goal in goalList)
                {

                    Console.Write(listCount + ".");
                    Console.WriteLine(goal.DisplayProgress());
                    listCount ++;
                }

                Console.WriteLine("Which goal would you like to record as doing?");
                int eventChoice = int.Parse(Console.ReadLine());

                goalPoints += goalList[eventChoice-1].MarkComplete();


            }

            // 6 will end loop
        }




    }
}
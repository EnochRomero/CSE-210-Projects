using System;
using RandomPrompt;
using Entry;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMenu()
        {
            Console.WriteLine("Please Select One of the Following Choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        }

        string choice = "0";
        List<string> entries = new List<string>();

        while (choice != "5")
        {

        DisplayMenu();

        choice = Console.ReadLine();

        // WRITE
        if (choice == "1")
        {
            UserEntry NewEntry = new UserEntry();
            Console.WriteLine(NewEntry._givenPrompt);
            NewEntry._userTextEntry = Console.ReadLine();

            Console.WriteLine("On a scale from 1-10, how happy are you today?");
            NewEntry._userMood = Console.ReadLine();
            entries.Add(NewEntry.MakeEntry());
        }

        // DISPLAY
        else if (choice == "2")
        {
            
            foreach (string item in entries)
                {
                    Console.WriteLine();
                    Console.WriteLine(item);
                    Console.WriteLine();
                    Console.WriteLine("======================================");
                }
            
        }

        // LOAD
        else if (choice == "3")
        {
            Console.Write("What is the name of the file you'd like to load?:");
            string file = Console.ReadLine();

            if (File.Exists(file))
                {
                    entries.Clear();
                    string allText = File.ReadAllText(file); 
                    string [] laodedEntries = allText.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (string entry in laodedEntries)
                    {
                        entries.Add(entry.Trim());
                    }
                }
            else
                {
                    Console.WriteLine("File not found.");
                }
        }

        // SAVE
        else if (choice == "4")
        {
            Console.Write("What would you like to name this file?:");
            string file = Console.ReadLine();

            File.WriteAllText(file, string.Join("\n\n", entries));
        }

        // QUIT. The loop will end if a 5 is entered.
            
        }
    }
}
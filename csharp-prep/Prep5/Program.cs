using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName ()
        {

            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptFavNumber()
        {
            Console.Write("What is your favorite number? ");
            int FavNumber = int.Parse(Console.ReadLine());

            return FavNumber;
        }

        static int PromptBirthYear()
        {
            Console.Write("What year were you born? ");
            int birthYear = int.Parse(Console.ReadLine());

            return birthYear;
        }

        
        static int SquareNumber(int number)
        {
            int numberSquared = number*2;

            return numberSquared;
        }

        static void DisplayMassage(string name, int squaredNumber, int birthYear)
        {
            Console.WriteLine($"{name}, the sqaure of your number is {squaredNumber}");
            Console.WriteLine($"{name}, you will turn {2026-birthYear} this year.");
        }

        static void main()
        {
            DisplayWelcome();

            string name = PromptUserName();

            int favNumber = PromptFavNumber();

            int birthYear = PromptBirthYear();

            int squaredNumber = SquareNumber(favNumber);

            DisplayMassage(name, squaredNumber, birthYear);

        }

        main();

    }
}
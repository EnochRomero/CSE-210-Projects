using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomNumberGenerator = new Random();

        int magicNumber = randomNumberGenerator.Next(1,101);

        int guess = -10000;

        while (guess != magicNumber)
        {
            Console.WriteLine ("What is the magic number?");
            guess = int.Parse(Console.ReadLine());

            if (guess > magicNumber)
            {
                Console.WriteLine("Your guess is too high!");
            }

            else if (guess < magicNumber)
            {
                Console.WriteLine("Your guess is too low!");
            }

            else if (guess == magicNumber)
            {
                Console.WriteLine("You got it!");
            }

        }



    }
}
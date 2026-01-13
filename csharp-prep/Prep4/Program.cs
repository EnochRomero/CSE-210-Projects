using System;
using System.Formats.Asn1;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        int guess = -1;

        List<int> numbers = new List<int>();

        while (guess != 0)
        {
            Console.Write("Enter a number: ");

            guess = int.Parse(Console.ReadLine());

            numbers.Add(guess);
        }

        Console.WriteLine($"The sum of the numbers is: {numbers.Sum()} ");

        Console.WriteLine($"The highest number is: {numbers.Max()}");

        Console.WriteLine($"The average of all numbers entered is: {numbers.Average()}");

    }
}
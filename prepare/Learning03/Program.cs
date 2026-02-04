using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.Divide());

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.Divide());

        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.Divide());


        Fraction fractionRandom = new Fraction();
        Random random = new Random();
        
        int i = 0;
        while (i < 21)
        {
            i += 1;

            int topValue = random.Next(1, 10);
            int buttomValue = random.Next(1,10);

            fractionRandom.SetNumerator(topValue);
            fractionRandom.SetDenominator(buttomValue);

            Console.WriteLine(fractionRandom.GetFractionString());
            Console.WriteLine(fractionRandom.Divide());

        }
    }
}
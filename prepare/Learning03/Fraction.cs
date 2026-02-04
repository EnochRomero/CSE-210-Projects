using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;

        _denominator = 1;
    }

    public Fraction(int num)
    {
        _numerator = num;

        _denominator = 1;
    }

    public Fraction(int num, int den)
    {
        _numerator = num;

        _denominator = den;
    }

    public double Divide()
    {
        return (double)_numerator / _denominator;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_numerator}/{_denominator}";
        return fractionString;
    }

    public double GetDenominator()
    {
        return _denominator;
    }
    public double GetNumerator()
    {
        return _numerator;
    }

    public void SetDenominator(int setDen)
    {
        _denominator = setDen;
    }

    public void SetNumerator(int setNum)
    {
        _numerator = setNum;
    }
}
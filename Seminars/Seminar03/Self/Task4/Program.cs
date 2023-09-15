using System;

class Program
{

    static double F(double x, double y)
    {
        if (x < y)
        {
            return Math.Sin(x) + Math.Cos(y) * Math.Cos(y);
        }
        else if (x == y)
        {
            return Math.Log(Math.Abs(x));
        }
        else
        {
            return Math.Sin(x * x) + Math.Cos(y);
        }
    }
    static void Main()
    {
        double.TryParse(Console.ReadLine(), out double x);
        double.TryParse(Console.ReadLine(), out double y);
        Console.WriteLine(F(x, y));
    }
}


using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (input.Length != 3)
        {
            Console.WriteLine("Wrong number of arguments");
            return;
        }
        if (!double.TryParse(input[0], out double a) || !double.TryParse(input[1], out double b) || !double.TryParse(input[2], out double c))
        {
            Console.WriteLine("Wrong types of arguments");
            return;
        }
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine(c == 0 ? "Infinite number of roots" : "No roots");
            }
            else
            {
                Console.WriteLine($"x = {-c / b}");
            }
        }
        else if (b == 0)
        {
            Console.WriteLine(c > 0 ? "No roots" : $"x = {Math.Sqrt(-c / a)}\nx = {-Math.Sqrt(-c / a)}");
        }
        else
        {
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("No roots");
            }
            else if (d == 0)
            {
                Console.WriteLine($"x = {-b / (2 * a)}");
            }
            else
            {
                Console.WriteLine($"x = {(-b + Math.Sqrt(d)) / (2 * a)}\nx = {(-b - Math.Sqrt(d)) / (2 * a)}");
            }
        }
    }
}
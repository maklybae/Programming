using System;

int.TryParse(Console.ReadLine(), out int n);
double.TryParse(Console.ReadLine(), out double l);

double s = (n * l * l) / (4 * Math.Tan(Math.PI / n));
Console.WriteLine($"{s:f2}");
using System;

const int r1 = 2;
const int r2 = 1;
string[] input = Console.ReadLine()!.Split(' ');
(double x, double y) d = (double.Parse(input[0]), double.Parse(input[1]));
double vector = d.x * d.x + d.y * d.y;
Console.WriteLine($"{d.x} {d.y}");
Console.WriteLine(vector);

if (vector < r1 * r1 && d.y > 0 || vector < r2 * r2 && d.y < 0 || -1 <= d.x && d.x <= 1 && d.y == 0)
{
    Console.WriteLine("Внутри области");
}
else if (vector == r1 * r1 && d.y >= 0 || vector == r2 * r2 && d.y <= 0 || d.y == 0 && 1 <= Math.Abs(d.x) && Math.Abs(d.x) <= 2)
{
    Console.WriteLine("На границе");
}
else
{
    Console.WriteLine("Не принадлежит области");
}
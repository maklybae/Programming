using System;

string[] input = Console.ReadLine()!.Split(' ');
(double x, double y) dot = (double.Parse(input[0]), double.Parse(input[1]));
double vector = dot.x * dot.x + dot.y * dot.y;


if (1 < vector && vector < 4 && dot.y >= 0)
{
    Console.WriteLine("Внутрь области");
}
else if ((vector == 4 || vector == 1) && dot.y >= 0 || dot.y == 0 && 1 <= Math.Abs(dot.x) && Math.Abs(dot.y) <= 2)
{
    Console.WriteLine("Граница области");
}
else
{
    Console.WriteLine("Не принадлежит обалсти");
}
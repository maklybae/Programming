using System;

string[] arguments = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
if (arguments.Length != 3)
{
    Console.WriteLine("Неверное число аргументов");
    return;
}
if (!double.TryParse(arguments[0], out var a) || !double.TryParse(arguments[2], out var b) || !"+-*/".Contains(arguments[1]) || arguments[1].Length != 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}

double ans;
switch (arguments[1])
{
    case "+":
        ans = a + b;
        break;
    case "-":
        ans = a - b;
        break;
    case "*":
        ans = a * b;
        break;
    case "/":
        ans = a / b;
        break;
    default:
        ans = double.PositiveInfinity;
        break;
}

if (double.IsInfinity(ans))
{
    Console.WriteLine("Переполнение!!!");
    return;
}
Console.WriteLine(ans);


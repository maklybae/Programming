using System;

namespace Task03;
class Program
{
    static void Main(string[] args)
    {
        if(!int.TryParse(Console.ReadLine(), out int command) || command < 1 ||  command > 4)
        {
            Console.WriteLine("Некорректный код операции");
            return;
        }
        if(!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Некорректный тип данных");
            return;
        }
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Некорректный тип данных");
            return;
        }
        switch (command)
        {
            case 1:
                Console.WriteLine($"{a} + {b} = {a + b}");
                break;
            case 2:
                Console.WriteLine($"{a} - {b} = {a - b}");
                break;
            case 3:
                Console.WriteLine($"{a} * {b} = {a * b}");
                break;
            case 4:
                Console.WriteLine($"{a} / {b} = {a / b}");
                break;
        }
    }
}

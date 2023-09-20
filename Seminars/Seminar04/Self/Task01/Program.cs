using System;

char symbol = (char)Console.Read();
switch (symbol)
{
    case char chr when char.IsDigit(chr):
        Console.WriteLine(100);
        break;
    case char chr when char.IsUpper(chr):
        Console.WriteLine(200);
        break;
    case char chr when char.IsLower(chr):
        Console.WriteLine(300);
        break;
    default:
        Console.WriteLine(400);
        break;
}

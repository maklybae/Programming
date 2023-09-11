using static System.Console;

BackgroundColor = ConsoleColor.Green;
ForegroundColor = ConsoleColor.Red;
Clear();
string? surname = ReadLine();
string? name = ReadLine();
string? patronymic = ReadLine();

WriteLine($"Hello, {surname} {name} {patronymic}");
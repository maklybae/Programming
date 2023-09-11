using static System.Console;

double.TryParse(ReadLine(), out double u);
double.TryParse(ReadLine(), out double r);

WriteLine($"I = {u / r}");
WriteLine($"P = {u * u / r}");
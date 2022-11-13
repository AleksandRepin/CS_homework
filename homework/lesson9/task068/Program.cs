Console.WriteLine("Введите начальное число M:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число N:");
int n = int.Parse(Console.ReadLine());

///Метод вычисления функции Аккермана:
int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 || n == 0) return AckermannFunction(n - 1, 1);
    if (m > 0 || n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
return AckermannFunction(m, n);
}

Console.WriteLine($"A({m},{n}) = {AckermannFunction(m, n)} ");
Console.WriteLine("Enter number M:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number N:");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
return AckermannFunction(m, n);
}

Console.WriteLine($"A({m},{n}) = {AckermannFunction(m, n)} ");
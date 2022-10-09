
static void task013()
{
    int value = new Random().Next(1, 2147483647);
    Console.WriteLine(value);
    if (value > 99)
    {
        int res = value / 100 % 10;
        Console.WriteLine(res);
    }
    else
    {
        Console.Write("Третьей цифры нет");
    }
}
task013();
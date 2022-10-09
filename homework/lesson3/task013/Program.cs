task013();

static void task013()
{
    int value = new Random().Next(10000, 99999);
    Console.WriteLine(value);
    int res1 = value % 100;
    int res2 = value / 1000;
    if (res1 == res2)
    {
        Console.WriteLine(value + " это число палиндром");
    }
    else
    {

    }
}
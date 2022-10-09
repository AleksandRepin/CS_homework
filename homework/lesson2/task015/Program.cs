static void task015()
{
    int[] weekDays = new int[] { 1, 2, 3, 4, 5, 6, 7 };
    int day = new Random().Next(1, 8);
    Console.WriteLine(day);

    if (day > 5)
    {
        Console.Write("Выходной");
    }
    else
    {

    }
}

task015();
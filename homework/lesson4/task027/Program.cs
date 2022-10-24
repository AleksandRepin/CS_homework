task027();

static void task027()
{
    Console.Write("Enter a number N: ");
    int num = Convert.ToInt32(Console.ReadLine());

    int sum = 0;
    for (int n = num; n > 0; sum = sum + n % 10, n = n / 10);
    Console.WriteLine(sum);
}
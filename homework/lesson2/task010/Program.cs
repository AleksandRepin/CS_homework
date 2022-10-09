

static void task010()
{
    int N = new Random().Next(100, 999);
    Console.WriteLine(N);
    int res = N / 10 % 10;
    Console.WriteLine(res);
}
task010();
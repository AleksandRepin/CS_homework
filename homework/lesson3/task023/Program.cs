Console.Write(" Enter number N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 1)
{
    Console.Write(" Enter number N > 0 ");
}
else
{
    int i = 1;
    while (i < N)
    {
        Console.WriteLine(i * i * i);
        i++;
    }
}

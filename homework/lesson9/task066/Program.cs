Console.WriteLine("Enter number M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number N:");
int N = Convert.ToInt32(Console.ReadLine());

void SumInIntervalFromMbeforeN (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Sum numbers from M before N = {sum}"); 
        return;
    }
    sum = sum + (M++);
    SumInIntervalFromMbeforeN(M, N, sum);
}

SumInIntervalFromMbeforeN(M, N, 0);
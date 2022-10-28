// откуда берем значение N
// создаем цикл с проверкой условия N % 2 == 0
// вывод результата

Console.Write("Enter a num N: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N > 1)
{
    if ( N % 2 == 0) Console.WriteLine(N);
    N = N - 1;
}

double metod(double A, int B)
{
    int i = 0;
    double result = 1;
    while (i < B)
    {
        result = result * A;
        i++;
    }
    return result;
}
Console.Write(" Enter a number A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write(" Enter a number B: ");
int B = Convert.ToInt32(Console.ReadLine());
double res = metod(A, B);
Console.WriteLine(res);
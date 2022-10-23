
double sum()
{
    int s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        s = N[i] + N[i + 1];
        return s;
    }
    Console.WriteLine(s);
}
sum();
// Console.Write(" Enter a number N: ");
// string N = Console.ReadLine();
// sum(res);
// Console.WriteLine(res);
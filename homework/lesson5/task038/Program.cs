void arrayFill(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = Random.Shared.Next(-1000, 1000);
        Console.Write($"{arg[i]} ");
    }
}

int findMax(int[] arg1)
{
    int max = arg1[0];
    for (int j = 0; j < arg1.Length; j++)
    {
        if (max < arg1[j]) max = arg1[j];
    }
    return max;
}

int findMin(int[] arg2)
{
    int min = arg2[0];
    for (int k = 0; k < arg2.Length;k++)
    {
        if (min > arg2[k]) min = arg2[k];
    }
    return min;
}

int[] array = new int[10];
arrayFill(array);
int Max = findMax(array);
Console.WriteLine();
Console.WriteLine(Max);
int Min = findMin(array);
Console.WriteLine(Min);

if (Min < 0)
{
    int res = (Max) - (-Min);
    Console.WriteLine(res);
}
else
{
    int res = (Max) - (Min);
    Console.WriteLine(res);
}


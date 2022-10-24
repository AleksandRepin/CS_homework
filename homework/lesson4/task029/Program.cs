void FillArray(int[] a)
{
    int L = a.Length;
    int i = 0;
    while (i < L)
    {
        a[i] = new Random().Next(-2147483648, 2147483647);
        i++;
    }
}

void PrintArray(int[] b)
{
    int k = b.Length;
    int j = 0;
    while (j < k)
    {
        Console.WriteLine(b[j]);
        j++;
    }
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
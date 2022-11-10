
void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] arg1)
{
    for (int i = 0; i < arg1.GetLength(0); i++)
    {
        for (int j = 0; j < arg1.GetLength(1); j++)
        {
            Console.Write($"{arg1[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SumOfAverageColumns(int[,] arg2)
{
    double average = arg2.GetLength(0);
    for (int j = 0; j < arg2.GetLength(1); j++)
    {
        double sum = 0;
        double x = 0;
        for (int i = 0; i < arg2.GetLength(0); i++)
        {
            sum += arg2[i, j];
        }
        x = sum / average;
        Console.Write($"{x} ");
    }
}

int[,] Matrix = new int[3, 4];
FillMatrix(Matrix);
PrintMatrix(Matrix);
Console.WriteLine();
SumOfAverageColumns(Matrix);






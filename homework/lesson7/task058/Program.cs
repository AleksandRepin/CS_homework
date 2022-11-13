
void AB(int[,] ab)
{
    int[,] matrix = new int[2,2];
    void A(int[,] a)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = new Random().Next(1, 10);
                Console.Write($"{a[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    void B(int[,] b)
    {
        for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                b[i, j] = new Random().Next(1, 10);
                Console.Write($"{b[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    Console.Write("MATRIX A: ");
    A(matrix);
    Console.Write("MATRIX B: ");
    B(matrix);
    // int ab00 = a[i, j] * b[i, j] + a[i, j + 1] * b[i + 1, j];
    // int ab01 = a[i, j] * b[i, j + 1] + a[i, j + 1] * b[i + 1, j + 1];
    // int ab10 = a[i + 1, j] * b[i, j] + a[i + 1, j + 1] * b[i + 1, j];
    // int ab11 = a[i + 1, j] * b[i, j + 1] + a[i + 1, j + 1] * b[i + 1, j + 1];
    // Console.Write($"{ab00} {ab01}");
    // Console.Write($"{ab10} {ab11}");
}

int[,] matrix = new int[2, 2];
AB(matrix);
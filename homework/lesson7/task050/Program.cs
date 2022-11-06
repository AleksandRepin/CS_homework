
// ввод позиции элемента
// проверка условия 
// показ элемента или нет такого элемента
Console.Write("Please enter element n = ");
int n = Convert.ToInt32(Console.ReadLine());

void fillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            arg[i, j] = new Random().Next(1, 10);
            Console.Write($"{arg[i, j]} ");
            if (n == arg[i, j])
            {
                Console.Write(n);
            }
            if (n!= arg[i, j])
            {
                Console.Write("No element n ");
            }            
        }
    Console.WriteLine();
    }
}


int[,] matrix = new int[3, 4];
fillMatrix(matrix);







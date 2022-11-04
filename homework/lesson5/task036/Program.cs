// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных
//  позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void arrayFill(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = Random.Shared.Next(-1000, 1000);
        Console.Write($"{arg[i]} ");
    }
}

void getSum(int[] arg1)
{
    int sum = 0;
    for (int j = 0; j < arg1.Length; j++)
    {
        if (j % 2 != 0)
        {
            sum = sum + arg1[j];
        }   
    }
    Console.WriteLine($" сумма нечетных элементов = {sum}");
}

int[] array = new int[10];
arrayFill(array);
getSum(array);




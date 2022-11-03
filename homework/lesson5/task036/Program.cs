﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных
//  позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array = new int[10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Random.Shared.Next(-100, 100);
    if (i % 2 != 0)
    {
        Console.WriteLine(array[i]);
    }
}
Console.WriteLine(String.Join(' ', array));



/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/
using System;
using static System.Console;
Clear();

int[] array = GetRandomArray(6, 0, 100);
Console.WriteLine($"[{String.Join(",",array)}]");
Console.WriteLine($"Сумма нечетных элементов в массиве = {GetSumUneven(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
int [] result = new int [size];
for (int i = 0; i < size; i++)
{
result [i] = new Random(). Next(minValue, maxValue);
}

    return result;
}

int GetSumUneven(int[] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (j % 2 != 0) sum += array[j];
    }
    return sum;
}
/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
using System;
using static System.Console;
Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

WriteLine($"Строка с наименьшей суммой - {GetRowNumber(array)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
int GetRowNumber (int [,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 0; i<array.GetLength(1); i++)
    {
        minsum = minsum + array[0,i];
    }

    for (int i = 1; i<array.GetLength(0); i++)
    {
        int sum = 0; 
        for (int j = 0; j<array.GetLength(1); j++)
        {
            sum = sum+array[i,j];
        }
        if (minsum > sum)
        {
            minsum = sum;
            row = i;
        }
    }
    return row;
}
﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine($"Сумма элементов главной диагонали = {GetSumDiag(array)}");

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
// 1 4 7 2
// 5 9 2 3


int GetSumDiag(int[,] array)
{
    int length = array.GetLength(0) < array.GetLength(1) ? array.GetLength(0) : array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

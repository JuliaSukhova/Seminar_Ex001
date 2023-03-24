// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using static System.Console;


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[,] GetInverse(int[,] num)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < num.GetLength(1) - 1; z++)
            {
                if (num[i, z] < num[i, z + 1])
                {
                    int k = 0;
                    k = num[i, z];
                    num[i, z] = num[i, z + 1];
                    num[i, z + 1] = k;
                }
            }
        }
    }
    return num;
}

void PrintArray(int[,] Noutput)
{
    for (int i = 0; i < Noutput.GetLength(0); i++)
    {
        for (int j = 0; j < Noutput.GetLength(1); j++)
        {
            Write(Noutput[i, j] + " ");
        }
        WriteLine();
    }
}

Write("Введите количество строк массива: ");
int line = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

WriteLine("Задан массив: ");

int[,] array = GetArray(line, columns, 0, 10);
PrintArray(array);

WriteLine($"В итоге получается вот такой массив: ");

int[,] number = GetInverse(array);
PrintArray (number);
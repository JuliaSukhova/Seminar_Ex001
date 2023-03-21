// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;

Write("Введите количество строк массива: ");
int info =int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int pillar=int.Parse(ReadLine());

double[,] array = GetArray(info , pillar, -10, 10);
PrintArray(array);

double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()* ((maxValue - minValue) + minValue);;
        }
    }
    return result;
}

void PrintArray(double[,] Noutput)
{
    for (int i = 0; i < Noutput.GetLength(0); i++)
    {
        for (int j = 0; j < Noutput.GetLength(1); j++)
        {
            Write($"{Noutput[i,j]: 0.#} ");
        }
        WriteLine();
    }
}
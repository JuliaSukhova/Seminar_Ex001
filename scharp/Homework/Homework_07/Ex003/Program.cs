// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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

void GetAvarage(int[,] num, int line)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < num.GetLength(0); i++)
        {
            avarage = (avarage + num[i, j]);
        }
        avarage = avarage / line;
        Write($"{avarage : 0.#}" + "; ");
    }
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

int[,] array = GetArray(line, columns, -10, 10);
PrintArray(array);

GetAvarage(array, line);
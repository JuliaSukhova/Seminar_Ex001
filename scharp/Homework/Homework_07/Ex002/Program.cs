// Задача 50. Напишите программу, которая 
//на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;

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

(int,int) PosFormat(int k)
{
    int i = k/10;
    int j = k%10;
    return (i,j);
}

static object CheckPos(int info, int pillar, int[,] array, int i, int j)
{
    if (i <= info && i > 0 && j <= pillar && j > 0)
    {
        return array[i - 1, j - 1];
    }
    else
    {
        return "такого числа в массиве нет";
    }
}

void PrintArray(int[,] Noutput)
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

Write("Введите количество строк массива: ");
int info =int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int pillar=int.Parse(ReadLine());

int[,] array = GetArray( info, pillar, 1, 9);
PrintArray(array);

Write("Введите позицию в массива: ");
int position =int.Parse(ReadLine());

(int,int) tuple = PosFormat(position);
int i = tuple.Item1;
int j = tuple.Item2;

Write($"{CheckPos(info, pillar,array, i, j)}");
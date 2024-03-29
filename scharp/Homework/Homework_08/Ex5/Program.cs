﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;


WriteLine("Введите размер массива");
int scale = Convert.ToInt32(ReadLine());

int[,] Noutput = new int[scale, scale];

int num = 1;
int i = 0;
int j = 0;

while (num <= scale * scale)
{
    Noutput[i, j] = num;
    if (i <= j + 1 && i + j < scale - 1)
        ++j;
    else if (i < j && i + j >= scale - 1)
        ++i;
    else if (i >= j && i + j > scale - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(Noutput);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
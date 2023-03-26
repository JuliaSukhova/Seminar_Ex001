// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;
using static System.Console;

int[,,] array = Create3DMassive(2, 2, 2);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                WriteLine($"{array[i, j, k]:00} - [{i}, {j}, {k}]");
            }
            WriteLine();
        }
    }

static int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[90];

    for (int i = 0; i < values.Length; i++)
    {
        values[i] = i + 10;
    }

    Random rnd = new Random();
    for (int i = values.Length - 1; i > 0; i--)
    {
        int j = rnd.Next(i + 1);
        int temp = values[i];
        values[i] = values[j];
        values[j] = temp;
    }

    int valueIndex = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}
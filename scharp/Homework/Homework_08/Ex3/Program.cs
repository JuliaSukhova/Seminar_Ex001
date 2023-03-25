// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] GetArray2(int m, int n, int minValue, int maxValue)
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


int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int m = matrixA.GetLength(0);
    int n = matrixA.GetLength(1);
    int p = matrixB.GetLength(1);

    int[,] result = new int[m, p];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < p; j++)
        {
            int sum = 0;
            for (int k = 0; k < n; k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
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

void PrintArray2(int[,] Noutput2)
{
    for (int i = 0; i < Noutput2.GetLength(0); i++)
    {
        for (int j = 0; j < Noutput2.GetLength(1); j++)
        {
            Write(Noutput2[i, j] + " ");
        }
        WriteLine();
    }
}

Write("Введите количество строк массива: ");
int line = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

WriteLine("Задан массив: ");

int[,] array = GetArray(line, columns, 0, 9);
PrintArray(array);

WriteLine(" ");

int[,] array2 = GetArray2(line, columns, 0, 9);
PrintArray2(array2);

WriteLine(" ");

int[,] number = MultiplyMatrices (array, array2);
PrintArray (number);
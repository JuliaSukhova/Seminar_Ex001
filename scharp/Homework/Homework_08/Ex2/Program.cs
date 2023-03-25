// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;


Write("Введите количество строк массива: ");
int line = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

WriteLine("Задан массив: ");

int[,] array = GetArray(line, columns, 0, 10);
PrintArray(array);

(int,int) tuple = GetInverse (array);
int i = tuple.Item1;
int j = tuple.Item2;

WriteLine("Строка с наименьшей суммой элементов под номером: " + (i));


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


(int, int) GetInverse(int[,] num)
{
    int sum = 0;
    int Min = Int32.MaxValue;
    int inde = 0;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            sum = sum + num[i, j];
        }
        if (sum < Min)
        {
            Min = sum;
            inde = i+1;
        }
        sum = 0;
    }
    return (inde,Min);
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
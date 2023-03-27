// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;
using static System.Console;

Clear();

Write("Введите N: ");
int n=int.Parse(ReadLine());

PrintNumbers(n);

static void PrintNumbers(int n)
{
    if (n == 1)
    {
        Write("1");
    }
    else
    {
        Write($"{n}, ");
        PrintNumbers(n - 1);
    }
}
WriteLine();
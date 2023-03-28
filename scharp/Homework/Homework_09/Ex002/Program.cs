// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;
using static System.Console;

Clear();

Write("Введите M: ");
int M = int.Parse(ReadLine());

Write("Введите N: ");
int N = int.Parse(ReadLine());

int sum = SumNaturalsBetween(M, N);
WriteLine(sum);

static int SumNaturalsBetween(int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n; i++)
    {
        if (i > 0)
        {
            sum += i;
        }
    }
    return sum;
}
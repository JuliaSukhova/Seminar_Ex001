// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int i = 1;
int n = 0;

NewMethod();

int A = NewMethod2();

NewMethod1(ref i, ref n, A);

Console.WriteLine(n);

static void NewMethod()
{
    Console.Write("Введите число: ");
}

static void NewMethod1(ref int i, ref int n, int A)
{
    for (i = 1; i <= A; i++)
    {
        n = n + i;
    }
}

static int NewMethod2()
{
    return Convert.ToInt32(Console.ReadLine());
}
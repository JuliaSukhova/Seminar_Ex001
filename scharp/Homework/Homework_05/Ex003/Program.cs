// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Vvod(string message) // ввод числа с экрана
{
    Console.Write(message); // выводим приглос ко вводу
    string read = Console.ReadLine();
    int resul = int.Parse(read); // приводим к числу
    return resul; // возвращаем результат
}

int sine = Vvod("Введите длину массива ");

// метод для случайных чисел
int[] Metod(int Length)
{
    int[] array = new int[Length]; //объявляем массив
    for (int i = 0; i < Length; i++)
    {
        array[i] = new Random().Next(1, 1000) / 100; // заполняем диапазон 
    }
    return array;
}

int[] num = Metod(sine);
double min = Int32.MaxValue;
double max = Int32.MinValue;
int count = 0;

for (int n = 0; n < num.Length; n += 2)
{
    if (num[n] > max)
    {
        max = num[n];
    }
    if (num[n] < min)
    {
        min = num[n];
    }
}

void PrintArray(int[] num, int count)
{
    Console.Write("[ ");
    for (int n = 0; n < num.Length; n++)
    {
        Console.Write(num[n] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine($"Максимальное = {max}, минимальное = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

PrintArray(num, count);
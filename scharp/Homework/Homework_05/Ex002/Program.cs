// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Numer(string message) // ввод числа с экрана
{
    Console.Write(message); // выводим приглос ко вводу
    string read = Console.ReadLine();
    int resul = int.Parse(read); // приводим к числу
    return resul; // возвращаем результат
}

int size = Numer("Введите длину массива ");

// метод для случайных чисел
int[] metod2(int Length)
{
    int[] array = new int[Length]; //объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(1, 99); // заполняем диапазон 
    }
    return array;
}

int[] num = metod2(size);
int sum = 0;
int count = 0;

for (int n = 0; n < num.Length; n += 2)
{
    sum = sum + num[n];
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

PrintArray(num, count);
Console.Write($" -> {sum} ");
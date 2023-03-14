// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int New(string message) // ввод числа с экрана
{
    Console.Write(message); // выводим приглос ко вводу
    string read = Console.ReadLine();
    int resul = int.Parse(read); // приводим к числу
    return resul; // возвращаем результат
}

int size = New("Введите длину массива ");

// метод для случайных чисел
int[] metod1(int Length)
{
    int[] array = new int[Length]; //объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i]= random.Next(100, 999); // заполняем диапазон 
    }
    return array;
}

int[] num = metod1(size);
int count = 0;

count = NewMethod(num, count);

Console.Write(" ");
Console.WriteLine($"{count} ");

static int NewMethod(int[] num, int count)
{
    for (int n = 0; n < num.Length; n++)
    {
        Console.WriteLine(num[n]);
        if (num[n] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33  -> [1, 2, 5, 7, 19, 6, 1, 33]

int Prom(string message) // ввод числа с экрана
{
    System.Console.Write(message); // выводим приглос ко вводу
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput); // приводим к числу
    return result; // возвращаем результат
}

// метод для случайных чисел
int[] ArrayNum(int Length, int min, int max)
{
    int[] array = new int[Length]; //объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++);
    {
        array[i]= random.Next(min,max + 1); // заполняем диапазон 
    }
    return random;
}

void Print(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++); // вывод значения массивы
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}"); // вывод значения массива
    Console.Write("]");
}

int Length = Prom ("Длина массива: ");
int min = Prom("Начальное значение: ");
int max = Prom("Конечное значение: ");
int [] array = ArrayNum(Length,min,max); // заполнение массива
Print(array); // вывод
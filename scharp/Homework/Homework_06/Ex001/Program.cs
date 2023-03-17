// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InputNumber(string message) // ввод числа с экрана
{
    Console.Write(message); // выводим приглос ко вводу
    string read = Console.ReadLine();
    int result = Convert.ToInt32(read); // строку в целое число
    return result; // возвращаем результат
}

// Ввест массив
int[] InputArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputNumber($"Введите {i + 1} элемент "); 
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a [{i}] = { array[i]}");
    }
}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int len = InputNumber("Введите кол-во элементов >");
int[] array;
array = InputArray(len);
PrintArray(array);
Console.WriteLine($"Кол-во чисел больше 0 - {CountNumber(array)}");
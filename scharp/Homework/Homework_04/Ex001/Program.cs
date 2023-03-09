// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prom(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Nume(int a, int b)
{
    int c = 1;
    while (b != 0)
    {
        c = c * a;
        b = b - 1; 
    }
    return c;
}

int a = Prom("Введите основание: ");
int b = Prom("Введите показатель: ");

    System.Console.WriteLine($"Число {a} в степень {b} равно {Nume(a,b)})");
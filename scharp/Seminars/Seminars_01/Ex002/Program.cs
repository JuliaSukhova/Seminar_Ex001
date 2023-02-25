Console.WriteLine("Задача 2");

int index;
Console.WriteLine ("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

for (index = 1; index <= N; index++ )
 {
    if (index % 2 == 0)
    {
        Console.WriteLine(index);
    }
 }
int i,a;

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for (i = 1; i <= n; i++)
{
    a = i*i*i;
    Console.WriteLine(a);
}
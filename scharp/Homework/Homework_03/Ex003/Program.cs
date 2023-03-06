int i= 0;
int a = 0;

int n = NewMethod();

NewMethod1(i, a, n);

static int NewMethod()
{
    Console.WriteLine("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

static void NewMethod1(int i, int a, int n)
{
    for (i = 1; i <= n; i++)
    {
        a = i * i * i;
        Console.WriteLine(a);
    }
}
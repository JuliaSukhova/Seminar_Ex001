int i, rev, d;

int n = NewMethod1();

n = NewMethod(out i, out rev, out d, n);

static int NewMethod(out int i, out int rev, out int d, int n)
{
    i = n;
    rev = 0;
    d = 0;
    while (n > 0)
    {
        d = n % 10;
        rev = rev * 10 + d;
        n = n / 10;
    }
    if (rev == i)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }

    return n;
}

static int NewMethod1()
{
    Console.WriteLine("Введте число");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
string GetNumbers(int count)
{
    string output = String.Empty;
    int index = 1;

    while (index <= count)
    {
        if (index % 2 = 0)
            if (index >= count - 1) output = output + index;
            else
                output = output + index + ", ";
        index++;
    }
    return output;
}
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
string res = GetNumbers(N);

Console.WriteLine(res);
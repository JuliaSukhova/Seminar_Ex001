int Prompt(string massage)
{
Console.Write(massage);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result; 
}

int GetThirdRank(int n)
{   
    while (n > 999)
    {
    n /= 10;
    }
    return n % 10;
}

bool ValidateNumber(int n)
{
    if (n < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
}

int n = Prompt("Введите число: ");
if (ValidateNumber(n))
{
    Console.WriteLine(GetThirdRank(n));
}
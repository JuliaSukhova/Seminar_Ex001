int x_1, y_1, z_1, x_2, y_2, z_2;

x_1 = Name("x", "A");
y_1 = Name("y","A");
z_1 = Name("z","A");
x_2 = Name("x","B");
y_2 = Name("y","B");
z_2 = Name("z","B");

int Name(string kord, string tochka)
{
    Console.Write($"Введите координату {kord} точки {tochka}: ");
    return Convert.ToInt32(Console.ReadLine());
}


double result (double x_1, double x_2, 
                double y_1, double y_2, 
                double z_1, double z_2)
{
  return Math.Sqrt(Math.Pow((x_2-x_1), 2) + 
                   Math.Pow((y_2-y_1), 2) + 
                   Math.Pow((z_2-z_1), 2));
}

double answer =  Math.Round(result (x_1, x_2, y_1, y_2, z_1, z_2), 2 );

Console.WriteLine(answer);
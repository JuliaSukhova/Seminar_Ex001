int x1 = Name("x", "A");
int y1 = Name("y", "A");
int z1 = Name("z", "A");
int x2 = Name("x", "B");
int y2 = Name("y", "B");
int z2 = Name("z", "B");

int Name(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}


double result (double x1, double x2, 
                double y1, double y2, 
                double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round(result (x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine(segmentLength);
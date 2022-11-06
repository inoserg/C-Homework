Console.WriteLine("Введите координаты x1");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y1");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z1");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x2");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y2");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты z2");
int z2 = Convert.ToInt32(Console.ReadLine());

double Range(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int RangeX = x2-x1;
    int RangeY = y2-y1;
    int RangeZ = z2-z1;
    double range3d = Math.Sqrt(RangeX*RangeX + RangeY*RangeY + RangeZ*RangeZ);
    return range3d;
}

double result = Range(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2}) -> {Math.Round (result, 2, MidpointRounding.ToZero)}");
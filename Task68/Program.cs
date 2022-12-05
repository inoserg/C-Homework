Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 && n < 0) Console.WriteLine("Введите целые числа!");

int Ackerman(int m, int n)
{
    if (m == 0)
        return n + 1;

    else if (n == 0)
        return Ackerman(m - 1, 1);

    else return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.WriteLine($"m = {m}, n = {n} -> A = {Ackerman(m, n)}");
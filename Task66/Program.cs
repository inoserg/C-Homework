Console.WriteLine("Введите значение M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());

FindNatural (M, N);

int FindNatural (int M, int N)
{
    if (M == N) return N;
    else return N + FindNatural (M, N - 1);
}

Console.WriteLine($"Сумма всех чисел от {M} до {N} - {FindNatural(M,N)}");
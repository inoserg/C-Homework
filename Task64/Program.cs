Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());

int M = 0;

int FindNatural (int N, int M)
{
    if (M == N) return N;
    else
    Console.Write($"{FindNatural(N, M + 1)}, ");
    return M;
}

FindNatural (N, M);
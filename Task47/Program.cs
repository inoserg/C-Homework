double [,] array = new double [3,4];

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             array[i, j] = new Random().NextDouble()*(10 - (-10)) + -10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write($"{Math.Round (array[i,j], 2, MidpointRounding.ToZero)}; ");
        }
        Console.WriteLine();
    }
}

FillArray(array);
PrintArray(array);
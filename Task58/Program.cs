int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];

FillArray(array1); PrintArray(array1);
Console.WriteLine();
FillArray(array2); PrintArray(array2);
Console.WriteLine();

int[,] mult = new int[2, 2];

for (int i = 0; i < mult.GetLength(0); i++)
{
    for (int j = 0; j < mult.GetLength(1); j++)
    {
        mult[i,j] =+ array1[i, j] * array2[i,j];
    }
}

PrintArray(mult);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; ");
        }

        Console.WriteLine();
    }
}
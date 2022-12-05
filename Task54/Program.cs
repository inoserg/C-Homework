int[,] ArrayElements = new int[3, 4];

Console.WriteLine("Делаем массив..."); Console.WriteLine();

FillRandomArray(ArrayElements); PrintArray(ArrayElements); Console.WriteLine();

Console.WriteLine("Теперь упорядочим..."); Console.WriteLine();

for (int i = 0; i < ArrayElements.GetLength(0); i++)
{
    for (int j = 0; j < ArrayElements.GetLength(1) - 1; j++)
    {
        for (int z = 0; z < ArrayElements.GetLength(1) - 1; z++)
        {
            if (ArrayElements[i, z] < ArrayElements[i, z + 1])
            {
                int temp = ArrayElements[i, z];
                ArrayElements[i, z] = ArrayElements[i, z + 1];
                ArrayElements[i, z + 1] = temp;
            }
        }
    }
}

PrintArray(ArrayElements);

void FillRandomArray(int[,] ArrayElements)
{
    for (int i = 0; i < ArrayElements.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayElements.GetLength(1); j++)
        {
            ArrayElements[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] ArrayElements)
{
    for (int i = 0; i < ArrayElements.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayElements.GetLength(1); j++)
        {
            Console.Write($"{ArrayElements[i, j]}; ");
        }

        Console.WriteLine();
    }
}
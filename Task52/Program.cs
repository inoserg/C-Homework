int[,] ArrayElements = new int[3, 4];

FillRandomArray(ArrayElements);
PrintArray(ArrayElements);
Console.WriteLine();

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

for (int j = 0; j < ArrayElements.GetLength(1); j++)
{
    double average = 0;

    for (int i = 0; i < ArrayElements.GetLength(0); i++)
    {
        average = (average + ArrayElements[i, j]);
    }
    average = average / 3;
    Console.Write($"{Math.Round(average, 2, MidpointRounding.ToZero)}; ");
}

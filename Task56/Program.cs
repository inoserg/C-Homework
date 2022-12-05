int[,] ArrayElements = new int[3, 4];
int minline = 0;
int min = 9999;

FillRandomArray(ArrayElements); PrintArray(ArrayElements);
Console.WriteLine();

for (int i = 0; i < ArrayElements.GetLength(0); i++)
{
    int sum = 0;

    for (int j = 0; j < ArrayElements.GetLength(1); j++)
    {
        sum = +ArrayElements[i, j];
    }
    if (sum <= min)
    {
        min = sum;
        minline++;
    }
}

Console.WriteLine($"Номер строки с наименьшей суммой элементов - {minline}");

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
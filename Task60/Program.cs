int[,,] array = new int[2, 2, 2];
List<int> listNumbers = new List<int>();

FillArray(array); PrintArray(array);

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                do
                {
                    array[i, j, k] = new Random().Next(10, 99);
                }
                while (listNumbers.Contains(array[i, j, k]));

                listNumbers.Add(array[i, j, k]);
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}); ");
            }
        }
        Console.WriteLine();
    }
}
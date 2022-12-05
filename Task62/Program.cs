int[,] array1 = new int[4, 4];

int counter = 1;
int i = 0;
int j = 0;

while (counter <= array1.GetLength(0) * array1.GetLength(1))
{
    array1[i, j] = counter;
    counter++;
    if (i <= j + 1 && i + j < array1.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array1.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array1.GetLength(1) - 1)
        j--;
    else
        i--;
}

PrintArray(array1);

void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]}; ");
        }

        Console.WriteLine();
    }
}
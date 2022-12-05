int [,] ArrayElements = new int [3,4];

void FillRandomArray(int [,] ArrayElements)
{
    for (int i = 0; i < ArrayElements.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayElements.GetLength(1); j++)
        {
             ArrayElements[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int [,] ArrayElements)
{
    for (int i = 0; i < ArrayElements.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayElements.GetLength(1); j++)
        {
        Console.Write($"{ArrayElements[i,j]}; ");
        }
        Console.WriteLine();
    }
}

FillRandomArray(ArrayElements);
PrintArray(ArrayElements);

Console.WriteLine("Введите номер строки");
   int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
   int column = Convert.ToInt32(Console.ReadLine());

if (row > 4 && column > 3)
{
    Console.WriteLine("Элемент не найден");
}

else
{
    Console.WriteLine($"Искомый элемент - {ArrayElements[row-1,column-1]}");
}

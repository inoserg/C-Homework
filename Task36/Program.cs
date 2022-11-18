int[] array = new int[4];
int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(1,10);
      Console.WriteLine($"Num {i+1} - {array[i]}");

       if (i%2==0)sum+=array [i];
}

Console.WriteLine($"Сумма нечётных элементов - {sum}");
int[] array = new int[4];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(1,999);

     if((array [i])%2==0)count++;
     
      Console.WriteLine($"{array[i]}");
}

Console.WriteLine($"Чётных чисел - {count}");
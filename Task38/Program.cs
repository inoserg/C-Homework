double[] array = new double [4];
double min = 0;
double max = 0;
double diff= 0;

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().NextDouble()*100;
      Console.WriteLine($"{Math.Round (array[i], 2, MidpointRounding.ToZero)}");
        max = array.Max();
         min = array.Min();
          diff = max-min;
      }

Console.WriteLine($"Min = {Math.Round (min, 2, MidpointRounding.ToZero)}, max = {Math.Round (max, 2, MidpointRounding.ToZero)}\nDifference = {Math.Round (diff, 2, MidpointRounding.ToZero)}");
 
 
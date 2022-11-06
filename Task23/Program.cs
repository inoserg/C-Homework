Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;

while (count <= number)
   {Console.WriteLine($"{count} -> {count*count*count}");
      count++;
      }



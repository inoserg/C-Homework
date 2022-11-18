Console.WriteLine("Введите координату b1");
   int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату k1");
   int k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату b2");
   int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату k2");
   int k2 = Convert.ToInt32(Console.ReadLine());

  double x = ((b2-b1)/(k1-k2));
   double y = (k1*(b2-b1)/(k1-k2)+b1);

    Console.WriteLine($"Точка пересечения: {x}, {y}");

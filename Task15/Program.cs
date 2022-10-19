Console.WriteLine("Введите номер дня недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number>7||number<1)Console.WriteLine("Нет такого дня");

else if (number<=5)Console.WriteLine("Будний день...");

else Console.WriteLine("Выходной!");

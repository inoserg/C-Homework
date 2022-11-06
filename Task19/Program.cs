Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int length = number.ToString().Length;
   if (length!=5)Console.WriteLine("Число не пятизначное");

   else if (number/10000%10==number%10&number/1000%10==number/10%10) Console.WriteLine("Палиндром");
        else Console.WriteLine("Не палиндром");


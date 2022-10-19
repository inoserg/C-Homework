Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

int length = number.ToString().Length;

if (length != 3)Console.WriteLine("Число не трехзначное!");

else 
{int output = number/10%10;
Console.Write($"Вторая цифра - {output}!");
} 
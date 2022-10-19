Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int length = number.ToString().Length;

if (length < 3)Console.WriteLine("Третьей цифры нет");

else 
{ while (length > 3) {number=number/10; length = number.ToString().Length;}

Console.WriteLine($"Третья цифра - {number%10}");
}
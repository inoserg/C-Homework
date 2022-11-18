Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int power = Convert.ToInt32(Console.ReadLine());

if (power<0)Console.WriteLine("Введите натуральную степень!");

else {
double exponentiate(int number, int power)
{ 
    double numberinpower = Math.Pow(number, power);
    
    return numberinpower;
  }

double result = exponentiate(number, power);

Console.WriteLine($"{result}");
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int addition(int num)
{ 
    while (num >= 1)
    {
        sum += num%10;
        num = num/10;
    }

        return sum;
}

int result = addition(num); 

Console.WriteLine($"{result}");

//Не осилил, не понимаю почему не получается цикл
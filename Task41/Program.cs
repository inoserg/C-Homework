Console.WriteLine("Введите числа");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int positive = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)positive++;
}

Console.WriteLine($"Положительных чисел: {positive}");

//Честно признаюсь, что способ преобразования ввода в array я подсмотрел, т.к. не нашел где это на уроках разбиралось. 
//Если это неверное решение, подскажите пожалуйста какое подразумевалось
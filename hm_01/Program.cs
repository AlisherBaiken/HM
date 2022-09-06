Console.WriteLine("Введите число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"{number1} больше чем {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"{number2} больше чем {number1}");
}
else
{
    Console.WriteLine("Ввели два одинаковые числа");
}


Console.WriteLine("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number_3 = int.Parse(Console.ReadLine());
int max = number_1;
if (number_2 > max) max = number_2;
if (number_3 > max) max = number_3;
Console.WriteLine($" max = {max}");

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
for (int i = 2; i <= a; i = i + 2)
{
    Console.Write($"{i}, ");
}



Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine());
if (b%2 == 0){
    Console.Write($"{b} да четное");
}else {
Console.Write($"{b} нет не четное");
}


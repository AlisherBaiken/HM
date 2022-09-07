// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Ведите число:");
int a = int.Parse(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine($" {a} числo являются одновроменно кратным 7,23");
}else {
    Console.WriteLine($" {a} числo не являются одновроменно кратным 7,23");
}

// Console.WriteLine("Введите первое число ");
// int number1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите второе число ");
// int number2 = int.Parse(Console.ReadLine());

// int max = 0;

// if (number1 > number2)
// {
// max = number1 % number2;
// }
// else
// {
// max = number2 % number1;
// }
// if (max == 0)
// {
// Console.WriteLine($"{number1}, {number2} -> кратно");
// }
// else
// {
// Console.WriteLine($"{number1}, {number2} -> некратно, остаток {max}");
// }
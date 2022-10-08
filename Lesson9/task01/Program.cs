// Задача 63: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Clear();
Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());

string Numbers(int n)
{
if (n == 1)
{
return "1";
}
else
return Numbers(n - 1) + n;
}

Console.WriteLine(Numbers(a));
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"
Console.Clear();
Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int b = int.Parse(Console.ReadLine());

string Numbers(int n, int a)
{
    if (n == a)
    {
        return $"{Convert.ToString(a)}";
    }
    else
        return Numbers(n - 1, a) + n;
}

Console.WriteLine(Numbers(b, a));
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
Console.Clear();

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"{Sum(a)}");

int Sum(int n)
{
    if (n == 0) return 0;
    else return n % 10 + Sum(n / 10);
}
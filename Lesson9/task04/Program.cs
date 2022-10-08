// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("Введите число N");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число M");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} = {Boom(a, b)}");
int Boom(int a, int b)
{
    if (b == 0) return 1;
    else return a * Boom(a, b - 1);
}
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// Console.Clear();
// Console.Write("");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// int count = 0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if(arr[i]>0) count++;
// }

// Console.WriteLine($"количество чисел больше нуля -> {count}");

///////////////////////////////////////////////////////////
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = int.Parse(Console.ReadLine());

double Xmethod(int b1, int b2, int k1, int k2)
{
double x = 0;
double num = 0;
double num2 = 0;
num = b1 - b2;
num2 = k2 - k1;
x = num/num2;
return x;
}
double x = Xmethod(b1, b2, k1, k2);
double Ymethod(int b1, int k1, double x)
{
double y = 0;
y = k1*x + b1;
return y;
}

Console.WriteLine($" ({Xmethod(b1, b2, k1, k2)}, {Ymethod(b1, k1, x)} )");
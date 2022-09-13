// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число для нахождения ккубов чисел: ");
// int x = int.Parse(Console.ReadLine());
// int count = 1;

// Console.Write($"{x} -> ");
// while (count < x)
// {
// Console.Write($"{Math.Pow((count), 3)}, ");
// count++;
// }

// if (count == x)
// {
// Console.Write($"{Math.Pow((count), 3)}");
// }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты первой точки, через запятую");
// string[] values = Console.ReadLine().Split(',');
// int x1 = int.Parse(values[0]);
// int y1 = int.Parse(values[1]);
// int b1 = int.Parse(values[2]);

// Console.WriteLine("Введите координаты второй точки, через запятую");
// string[] values_2 = Console.ReadLine().Split(',');
// int x2 = int.Parse(values_2[0]);
// int y2 = int.Parse(values_2[1]);
// int b2 = int.Parse(values_2[2]);

// double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) +  Math.Pow(b2 - b1, 2)),2);

// Console.WriteLine($"Расстояние между двумя точками в 3D равно: {result}");

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число чтобы проверить зеркальность");
string[] values = Console.ReadLine().Split();
string lenght = values.Length;
string first =lenght[0];
string second = lenght[1];
string fourth = lenght[3];
string fifth = lenght[4];

if (first == fifth && second == fourth){
    Console.WriteLine($"Введите число {values} является зеркальным");
}else{
    Console.WriteLine($"Введите число {values} не является зеркальным");
}
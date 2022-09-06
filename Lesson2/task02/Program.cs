//  Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();
int num = new Random().Next(100, 1000);
int first = num / 100;
int second = num / 10;
int last = num - (second * 10);
Console.WriteLine("Рандомнное число: " + num);
Console.WriteLine($"Вывод числа после удаление цифра в середине {first}{last}"); //first * 10 + last}

// int num = new Random().Next(100, 1000);
// int a1 = num % 10;
// int a3 = num / 100;
// Console.WriteLine($"{num} - > {a3}{a1}");
// int num = new Random().Next(100,1000);
// int a1 = num / 100;
// int a2 = (num - a1 * 100) / 10;
// int a3 = (num - a1 * 100 - a2 * 10) % 10;
// Console.WriteLine($"Случайное число: {num}");
// Console.WriteLine($"Сотни: {a1}");
// Console.WriteLine($"Десятки: {a2}");
// Console.WriteLine($"Единицы: {a3}");
// int num_out = a1 * 10 + a3;
// Console.WriteLine($"Итоговое число: {num_out}");

// //операция с числом как с текстом
// string numstring = num.ToString();
// string cutstring = String.Concat(numstring[0], numstring[2]);
// Console.WriteLine($"Итоговое число (как строка): {cutstring}");
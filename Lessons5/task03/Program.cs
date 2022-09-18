// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];
for (int i = 0; i < size; i++)
{
res[i] = new Random().Next(minValue, maxValue + 1);
}
return res;
}
int count = 0;
Console.WriteLine("Введите число для проверки на наличие в массиве: ");
int n = int.Parse(Console.ReadLine());
// int[] array = GetArray(4, -10, 10);

// foreach (int el in array)
// {
// Console.Write($"{el * -1} ");
// }
// Console.WriteLine(" ");

int[] array = GetArray(5, 1, 10);
Console.Write("массив [");
for (int i = 0; i < array.Length; i++)
{
if (i != array.Length - 1) Console.Write($"{array[i]}, ");
else Console.Write($"{array[i]}"); // \r\n
if (array[i] == n)
{
count++;
}
}
Console.Write("] ");
Console.Write((count == 0 ? $"-> нет " : $"-> да, {count} раз(а)"));
//Console.Write(((count==2 || count==3 || count==4) ? "раза" : "раз"));

// Console.Clear();
//метод - генерация нового массива
// int[] GetArray(int size, int minValue, int maxValue)
// {
// int[] res = new int[size];
// Console.Write("[");
// for (int i = 0; i < size; i++)
// {
// res[i] = new Random().Next(minValue, maxValue + 1);
// Console.Write($"{res[i]} ");
// }
// Console.Write("]");
// return res;
// }

//создание и заплнение нового массива через метод
// int[] array = GetArray(12, -9, 9);

// Console.WriteLine();

// //вызов метода замены элементов массива
// ArrayReplace(array);

// void ArrayReplace(int[] Array1)
// {
// int length = Array1.Length;
// for (int k = 0; k < length; k++)
// {
// Array1[k] = -Array1[k];
// }
// }
//вывод массива после замены элементов
// PrintArray(array);

// void PrintArray(int[] arrayToPrint)
// {
// Console.Write("[");
// foreach (int arrayelem in arrayToPrint)
// {
// Console.Write($"{arrayelem} ");
// }
// Console.Write("]");
// }
// int[] array = GetArray(7, 1, 10);


// int res = 0;
// foreach (int el in array)
// {
// if (number == el)
// res = 1;
// }
// if (res == 1)
// {
// Console.WriteLine("YOU ARE WINNER");
// }
// else
// {
// Console.WriteLine("Попытайте удачу еще раз, YOU ARE LOSSER");
// }
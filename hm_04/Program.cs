// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
//  Console.Clear();

// Console.WriteLine("Введите число для возведения степени: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите сетепень возведения: ");
// int step = int.Parse(Console.ReadLine());

// Console.WriteLine($"Число {number} в {step} степени = "+ Math.Pow(number,step));
// Console.WriteLine($"Число {number} в {step} степени ->{Stepen(number,step)}");
// int Stepen (int numb, int numb2){
//     int mult = 1;
//     int index = 1;
//     while(index<=numb2){
//         mult = mult * numb;
//                 index++;
//     }
//     return mult;
// }



// //////////////////////////////////////////////////
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Clear();

// Console.WriteLine("Введите число для поолучения сумму: ");
// int numb = int.Parse(Console.ReadLine());

// int Sum(int number)
// {
//     int count = 10;
//     int i = 1;
//     while (number >= count)
//     {
//         count = count * 10;
//         i++;
//     }
//     return i;

// }
// int num = Sum(numb);
// int SummaChisel(int kol, int number)
// {
//     int summ = 0;
//     int index = 1;
//     while (index <= kol)
//     {
//         summ = summ + number % 10;
//         number = number / 10;
//         index++;
//     }
//     return summ;
// }
// Console.WriteLine($"{numb} -> {SummaChisel(num, numb)}");
////////////////////////////////////////////////
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.WriteLine("Метод выводит массив из случайных чисел");

void FillArray(int[] array)
{
    int lenght = array.Length;
    int index = 0;
    while (index < lenght)
    {
        array[index] = new Random().Next(0, 10);
        index++;
    }
}
void PrintArray(int[] arr)
{
    int index = 0;
    int lenght = arr.Length;
    Console.Write("[");
    while (index < lenght)
    {
        Console.Write($"{arr[index]},");
        index++;
           }

    Console.Write("]");
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
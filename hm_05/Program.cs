// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// int[] Sumarray(int[] summa)
// {
//     int count = 0;
//     foreach (var el in summa)
//     {
//         if (el % 2 == 0) count++;
//     }
//     return count; // ne smog naiti owibku rugaetsya na dannuiu stroku
// }
// void PrintArray(int[] print)
// {
//     foreach (var el in print)
//     {
//         Console.Write($"{el} ");
//     }
// }

// int[] numb = GetArray(4, 100, 999);
// PrintArray(numb);
// Console.Write($"-> {Sumarray(numb)}");

//////////////////////////////////////////////////////////////////
//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//         Console.Write($"{res[i]} ");
//     }
//     return res;
// }

// int[] array = GetArray(4, 0, 15);
// int[] Numbers(int[] arr)
// {
//     int index = 0;
//     int a = 0;
//     int sum = 0;
//     while (index < arr.Length)
//     {
//         if (a % 2 != 0){
//             sum= sum+arr[a];
//           } 
//              a++;
//             index++;
//     }
//     return sum;
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма нечетных элементов {Numbers(array)}");
////////////////////////////////////////////////////////////////////
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int[] array = GetArray(5, 1, 10);

int MaxNum(int[] maxnum)
{
    int index = 1;
    int max = maxnum[0];
    int a = 1;
    while (index < maxnum.Length)
    {
        if (maxnum[a] > max) max = maxnum[a];
        index++;
        a++;
    }
    return max;
}
int MinNum(int[] minnum)
{
    int index = 1;
    int min = minnum[0];
    int a = 1;
    while (index < minnum.Length)
    {
        if (minnum[a] < min) min = minnum[a];
        index++;
        a++;
    }
    return min;
}
Console.WriteLine();
Console.WriteLine($"Разница между мах и мин = {MaxNum(array) - MinNum(array)}");
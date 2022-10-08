// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Console.Clear();
// int[,] array = GetArray(4, 4, 0, 9);
// PrintArray(array);
// Console.WriteLine();
// int[,] array1 = AnaliticArray(array);
// PrintArray(array1);


// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i + j;
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }
// int[,] AnaliticArray(int[,] array1)
// {
//     int result = 0;
//     int result1 = 0;
//     for (int sum = 0; sum <= array1.GetLength(1); sum++)
//     {
//         for (int index = 0; index < array1.GetLength(1); index++)
//         {
//             for (int i = 0; i < array1.GetLength(0) - 1; i++)
//             {
//                 if (array1[index, i + 1] > array1[index, i])
//                 {
//                     result = array1[index, i + 1];
//                     result1 = array1[index, i];
//                     array1[index, i] = result;
//                     array1[index, i + 1] = result1;
//                 }
//             }
//         }
//     }
//     return array1;
// }
////////////////////////////////////////////////////////////////////////////////
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Clear();
// int[,] array = GetArray(5, 5, 0, 9);
// PrintArray(array);
// Console.WriteLine($"Строка{AnaliticArray(array)} имеет наименьшую сумму ");



// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i + j;
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }
// int[,] AnaliticArray(int[,] array1)
// {
//     int num = 0;
//     int sum = 0;
//     int sumMin = 1000;
//     int kol = 1;
//     int res = 0;
//     for (int index = 0; index <= array1.GetLength(1); index++)
//     {
//         sum = 0;
//         for (int i = 0; i < array1.GetLength(0); i++)
//         {
//             num = array1[index, i];
//             sum = sum + num;
//             num++;


//         }
//         Console.WriteLine($"Сумма{kol} строки = {sum}");
//         Console.WriteLine();
//         if (sum < sumMin)
//         {
//             sumMin = sum;
//             sum = sumMin;
//             res = kol;
//         }
//         kol++;
//     }
//     return res;
// }
//////////////////////////////////////////////////////////////////////////////////
//  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Clear();
// Console.WriteLine($"Введите колличество столбцов ");
// int colums =int.Parse(Console.ReadLine()?? string.Empty) ;

// Console.WriteLine($"Введите колличество строк "); 
// int rows = int.Parse(Console.ReadLine()?? string.Empty) ;

// int[,] array1 = GetArray(rows, colums, 0, 9);
// PrintArray(array1);
// Console.WriteLine();

// int[,] array2 = GetArray(rows, colums, 0, 9);
// PrintArray(array2);
// Console.WriteLine();

// int[,] newArray = Matrix(array1,array2);
// PrintArray(newArray);

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = i + j;
//         }
//     }
//     return result;
// }
// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }

// }

// int[,] Matrix(int[,] arr1, int[,] arr2)
// {
//     int b = arr1.GetLength(1);
//     int a = arr1.GetLength(0);
//     int[,] arrNew = new int[a, b];
//     for (int i = 0; i < arr1.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr2.GetLength(0); j++)
//         {
//             for (int k = 0; k < arr2.GetLength(1); k++)
//             {
//                 arrNew[i, j] += arr1[i, k] * arr2[k, j];
//             }
//         }
//     }
//     return arrNew;
// }
///////////////////////////////////////////////////////////////////////////////////
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// Console.Clear();
// int[,,] array = GetArray(2, 2, 2);
// PrintArray(array);
// int[,,] GetArray(int m, int n, int l)
// {
    
//     int[,,] result = new int[m, n, l];
//     result[0,0,0] = new Random().Next(10,21);
//     int r = result[0,0,0];
//     for(int i = 0; i<m; i++)
//     {
//         for(int j = 0; j<n; j++)
//         {
//             for(int e = 0; e<l; e++)
//             {   
//                 result[i,j,e] = new Random().Next(1,10) + r;
//                 r = result[i,j,e];
//             }
//         }
//     }
//     return result;
// }

// void PrintArray(int[,,] inArray)
// {
//     for(int i = 0; i<inArray.GetLength(0); i++)
//     {
//         for(int j = 0; j<inArray.GetLength(1); j++)
//         {
//             for(int e = 0; e<inArray.GetLength(2); e++)
//             {
//                 Console.Write($"{inArray[i,j,e]} ({i},{j},{e}) ");
//             }
//             Console.WriteLine();
//         }
        
//     }
    
// }
///////////////////////////////////////////////////////////////////
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = SpiralArray();
PrintArray(array);

int[,] SpiralArray()
{
    int[,] arr = new int[4,4];
    int count = 1;
    for(int j = 0; j < arr.GetLength(1); j++)
    {
       arr[0,j] = count;
       count++;
    }
    for(int i = 1; i < arr.GetLength(0); i++)
    {
        arr[i, arr.GetLength(0) -1] = count;
        count++;
    }
    for(int j = arr.GetLength(1) -2; j >=0; j--)
    {
        arr[arr.GetLength(1) -1, j] = count;
        count++;
    }
    for(int i = arr.GetLength(0)-2; i >0; i--)
    {
        arr[i,0] = count;
        count++;
    }
    int c = 1;
    int d = 1;
    while (arr[c, d + 1] == 0) 
    {
        arr[c, d] = count;
        count++;
        d++;
    }
    while(arr[c + 1,d] == 0)
    {
        arr[c,d] = count;
        count++;
        c++;
    }
     while(arr[c,d-1] == 0)
    {
        arr[c,d] = count;
        count++;
        d--;
    }
     while(arr[c-1,d] == 0)
    {
        arr[c,d] = count;
        count++;
        c--;
    }
    for (int i = 0; i < arr.GetLength(0); i++) 
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            if (arr[i,j] == 0) 
            {
                arr[i,j] = count;
            }
        }
    }
    return arr;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i<inArray.GetLength(0); i++)
    {
        for(int j = 0; j<inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
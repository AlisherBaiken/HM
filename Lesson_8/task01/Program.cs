//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
int[,] array = GetArray(5, 5, 0, 9);
PrintArray(array);
int[,] SwappedArray = SwapRows(array);
Console.WriteLine();
PrintArray(SwappedArray);
int[,] SwapRows(int[,] arrayToSwap)
{
    int rows = arrayToSwap.GetLength(0);
    int columns = arrayToSwap.GetLength(1);
    int [] rowsTemp = new int [columns];
    for (int i = 0; i < columns; i++)
    {
        rowsTemp[i]=arrayToSwap[0,i];
        arrayToSwap[0,i] = arrayToSwap[rows-1,i];
        arrayToSwap[rows-1,i]= rowsTemp[i];
    }
    return arrayToSwap;

}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}
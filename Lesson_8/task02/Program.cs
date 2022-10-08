//55 задача меняет строки на столбцы либо выдает ошибку 


 int[,] array = GetArray(2, 5, 0, 9);
PrintArray(array);
int[,] transArray = TransposeArray(array);
Console.WriteLine();
PrintArray(transArray);

int[,] TransposeArray(int[,] arrayToTranspose)
{
int rows = arrayToTranspose.GetLength(0);
int columns = arrayToTranspose.GetLength(1);
int[,] transposedArray = new int[columns, rows];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
{
transposedArray[j, i] = arrayToTranspose[i, j];
}
}
//Console.WriteLine(String.Join(", ", rowsTemp));
return transposedArray;
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
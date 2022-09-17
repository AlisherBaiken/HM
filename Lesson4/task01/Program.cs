
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Clear();
Console.Write("Введите числе: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма чисел = {GetSumNums(num)}");
int GetSumNums(int numbers)
{
    int sum = 0;
    while (numbers > 0)
    {
        sum += numbers; // sum = sum + numbers
        numbers--;     // numbers = numbers -1 
    }
    return sum;
}
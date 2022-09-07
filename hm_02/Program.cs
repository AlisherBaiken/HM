
Console.WriteLine("Ведите число:");
int number = int.Parse(Console.ReadLine());
if (number > 100 && number < 1000)
{
    int first_num = number % 100;
    int second_num = first_num / 10;
    Console.WriteLine($"Число по середине - {second_num}");
}
else
{
    Console.WriteLine("Веденное число не является трехзначным");
}
///////////////////////////////////
Console.WriteLine("Ведите число:");
string number2 = Console.ReadLine();
if (  number2.Length > 2)
{


    Console.WriteLine(number2[2]);
}
else if (number2.Length <= 2)
{
    Console.WriteLine($" {number2} - Третьей цифры нет");
}


/////////////////////////////////////////
Console.WriteLine("Ведите число от 1 до 7 : ");
int number3 = int.Parse(Console.ReadLine());

if (number3 == 7 || number3 == 6)
{
    Console.WriteLine($"Введенное число  является выходным днем");
}
else
{
    Console.WriteLine($"Введенное число не является выходным днем");
};

// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе = {GetSumInNumber(num, GetCountNums(num))}");
int GetCountNums(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;

    }
    return count;
}

int GetSumInNumber(int number, int count)
{
    int sum = 0;
    int i = 0;
    while (i < count)
    {
        int A = number % 10;
        number = number / 10;
        sum = sum + A;
        i++;
    }
    return sum;
}
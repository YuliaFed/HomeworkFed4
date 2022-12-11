// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число 1 (возводимое в степень): ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2 (степень): ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} = {GetDegree(A, B)}");

int GetDegree(int number1, int number2)
{
    int i = 1;
    int res = number1;
    while (i < number2)
    {
        res = res * number1;
        i++;
    }
    return res;
}

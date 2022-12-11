// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void ArrayRandom(int[] number)
{

    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(0, 100);
    }
}


void PrintArray(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{number[i]} ");
    }
}

int[] Array = new int[8];
ArrayRandom(Array);
PrintArray(Array);
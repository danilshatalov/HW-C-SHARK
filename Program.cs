// Задача 1
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Maath.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {A} в степени {B} ровняется {getPow(A, B)}");

// Задача 2 
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Cумма цифр в числе {num} получается {getSumNumb(num)}");

// Задача 3
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] Array = getRandomArray();
Console.Write($"[{String.Join(";", Array)}]");

/////////////-------------------Методы----------------------//////////////

int getPow(int x, int n)
{
    int sum = 1;
    for (int i = n; i > 0; i--)
    {
        sum = sum * x;
    }
    return sum;
}

int getSumNumb(int x)
{
    int sum = 0;
    while (x != 0)
    {
        sum = sum + x % 10;
        x = x / 10;
    }
    return sum;
}

int[] getRandomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

// Задача 1
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] firstArray = getArray(4, 100, 1000);
System.Console.WriteLine($"Первый массив: [{String.Join(", ", firstArray)}]");
System.Console.WriteLine($"Количество четных чисел в этом массиве: {isEvenNumb(firstArray)}");

// Задача 2
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. (позиции - это индексы, нечетные индексы это 1,3,5 и тд)

int[] secondArray = getArray(10, 0, 10);
System.Console.WriteLine($"Второй массив: [{String.Join(", ", secondArray)}]");

int sum = 0;
for (int i = 0; i < secondArray.Length; i++)
{
    if (i % 2 == 0) continue;
    else
    {
        sum += secondArray[i];
    }
}

System.Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");

// Задача 3 
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] thirdArray = getArray(6, 1, 6);
System.Console.WriteLine($"Третий массив: [{String.Join(", ", thirdArray)}]");


for (int i = thirdArray.Length - 1, n = 0; (i >= thirdArray.Length / 2 && n < thirdArray.Length / 2); i--, n++)
{
    int firstEl = thirdArray[i];
    int secondEl = thirdArray[n];
    int result = firstEl * secondEl;
    System.Console.WriteLine($"Последний элемент {firstEl} и первый элемент {secondEl}, а также результат {result}");
}


///--------Методы--------//////
int[] getArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

int isEvenNumb(int[] array)
{
    int counter = 0;
    foreach (int arrayItem in array)
    {
        if (arrayItem % 2 == 0)
        {
            counter += 1;
        }
    }
    return counter;
}
